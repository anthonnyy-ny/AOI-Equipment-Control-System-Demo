using AOIEquipmentControlSystem.Models;
using AOIEquipmentControlSystem.Services;

namespace AOIEquipmentControlSystem
{
    public partial class MainForm : Form
    {
        private readonly LoggerService _loggerService;
        private readonly MachineService _machineService;
        private readonly RecipeService _recipeService;
        private Recipe _currentRecipe = new();
        private int _logUpdateNumber;

        public MainForm()
        {
            InitializeComponent();

            _loggerService = new LoggerService();
            _machineService = new MachineService(_loggerService);
            _recipeService = new RecipeService();

            SetupResultTable();
            UpdateMachineStatus();
            AddLogUpdateHeader("System Startup");
            AddLogMessage("Application started.");
            ShowRecipeParameters();
        }

        private void InitializeButton_Click(object sender, EventArgs e)
        {
            RunMachineAction("Initialize", _machineService.Initialize());
        }

        private void StartAutoButton_Click(object sender, EventArgs e)
        {
            RunMachineAction("Start Auto", _machineService.StartAuto());

            if (_machineService.CurrentState == MachineState.Ready)
            {
                AddSimulatedResultRow();
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            RunMachineAction("Stop", _machineService.Stop());
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            RunMachineAction("Reset", _machineService.Reset());
        }

        private void ClearAlarmButton_Click(object sender, EventArgs e)
        {
            RunMachineAction("Clear Alarm", _machineService.ClearAlarm());
        }

        private void SaveRecipeButton_Click(object sender, EventArgs e)
        {
            AddLogUpdateHeader("Save Recipe");

            if (!TryParseRecipeText(recipeTextBox.Text, out Recipe recipe, out string errorMessage))
            {
                AddLogMessage(_loggerService.Error(errorMessage));
                return;
            }

            if (_recipeService.TrySaveRecipe(recipe, out string message))
            {
                _currentRecipe = recipe;
                recipeTextBox.Text = FormatRecipe(recipe);
                AddLogMessage(_loggerService.Info(message));
                return;
            }

            AddLogMessage(_loggerService.Error(message));
        }

        private void RunMachineAction(string actionName, List<string> logs)
        {
            AddLogUpdateHeader(actionName);

            foreach (string log in logs)
            {
                AddLogMessage(log);
            }

            UpdateMachineStatus();
        }

        private void UpdateMachineStatus()
        {
            machineStatusValueLabel.Text = _machineService.CurrentState.ToString();
            deviceStatusValueLabel.Text = _machineService.IsDeviceConnected ? "Connected" : "Disconnected";
            alarmMessageValueLabel.Text = string.IsNullOrWhiteSpace(_machineService.CurrentAlarmMessage)
                ? "None"
                : _machineService.CurrentAlarmMessage;

            bool isAlarm = _machineService.CurrentState == MachineState.Alarm;
            machineStatusValueLabel.ForeColor = isAlarm ? Color.Firebrick : Color.Black;
            alarmMessageValueLabel.ForeColor = isAlarm ? Color.Firebrick : Color.Black;
        }

        private void ShowRecipeParameters()
        {
            if (_recipeService.TryLoadRecipe(out Recipe recipe, out string message))
            {
                _currentRecipe = recipe;
                recipeTextBox.Text = FormatRecipe(recipe);
                AddLogMessage(_loggerService.Info(message));
                return;
            }

            recipeTextBox.Text =
                "Recipe load failed." + Environment.NewLine +
                "Please check Config/recipe.json.";
            AddLogMessage(_loggerService.Error(message));
        }

        private static string FormatRecipe(Recipe recipe)
        {
            return
                $"ProductName: {recipe.ProductName}" + Environment.NewLine +
                $"ExposureTime: {recipe.ExposureTime}" + Environment.NewLine +
                $"Threshold: {recipe.Threshold}" + Environment.NewLine +
                $"MinArea: {recipe.MinArea}" + Environment.NewLine +
                $"RoiX: {recipe.RoiX}" + Environment.NewLine +
                $"RoiY: {recipe.RoiY}" + Environment.NewLine +
                $"RoiWidth: {recipe.RoiWidth}" + Environment.NewLine +
                $"RoiHeight: {recipe.RoiHeight}" + Environment.NewLine +
                $"SavePath: {recipe.SavePath}" + Environment.NewLine +
                $"MaxRetryCount: {recipe.MaxRetryCount}";
        }

        private static bool TryParseRecipeText(string recipeText, out Recipe recipe, out string errorMessage)
        {
            recipe = new Recipe();
            errorMessage = string.Empty;

            Dictionary<string, string> fields = new(StringComparer.OrdinalIgnoreCase);
            string[] lines = recipeText.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);

            foreach (string rawLine in lines)
            {
                string line = rawLine.Trim();

                if (line.Length == 0)
                {
                    continue;
                }

                int separatorIndex = line.IndexOf(':');

                if (separatorIndex < 0)
                {
                    errorMessage = $"Invalid recipe line: {line}";
                    return false;
                }

                string fieldName = line[..separatorIndex].Trim();
                string fieldValue = line[(separatorIndex + 1)..].Trim();

                if (fieldName.Length == 0)
                {
                    errorMessage = "Invalid recipe field name.";
                    return false;
                }

                fields[fieldName] = fieldValue;
            }

            if (!TryGetRequiredText(fields, nameof(Recipe.ProductName), out string productName, out errorMessage) ||
                !TryGetRequiredInt(fields, nameof(Recipe.ExposureTime), out int exposureTime, out errorMessage) ||
                !TryGetRequiredInt(fields, nameof(Recipe.Threshold), out int threshold, out errorMessage) ||
                !TryGetRequiredInt(fields, nameof(Recipe.MinArea), out int minArea, out errorMessage) ||
                !TryGetRequiredInt(fields, nameof(Recipe.RoiX), out int roiX, out errorMessage) ||
                !TryGetRequiredInt(fields, nameof(Recipe.RoiY), out int roiY, out errorMessage) ||
                !TryGetRequiredInt(fields, nameof(Recipe.RoiWidth), out int roiWidth, out errorMessage) ||
                !TryGetRequiredInt(fields, nameof(Recipe.RoiHeight), out int roiHeight, out errorMessage) ||
                !TryGetRequiredText(fields, nameof(Recipe.SavePath), out string savePath, out errorMessage) ||
                !TryGetRequiredInt(fields, nameof(Recipe.MaxRetryCount), out int maxRetryCount, out errorMessage))
            {
                return false;
            }

            recipe = new Recipe
            {
                ProductName = productName,
                ExposureTime = exposureTime,
                Threshold = threshold,
                MinArea = minArea,
                RoiX = roiX,
                RoiY = roiY,
                RoiWidth = roiWidth,
                RoiHeight = roiHeight,
                SavePath = savePath,
                MaxRetryCount = maxRetryCount
            };

            return true;
        }

        private static bool TryGetRequiredText(
            Dictionary<string, string> fields,
            string fieldName,
            out string value,
            out string errorMessage)
        {
            if (!fields.TryGetValue(fieldName, out value!) || string.IsNullOrWhiteSpace(value))
            {
                errorMessage = $"Missing recipe field: {fieldName}.";
                value = string.Empty;
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        private static bool TryGetRequiredInt(
            Dictionary<string, string> fields,
            string fieldName,
            out int value,
            out string errorMessage)
        {
            if (!TryGetRequiredText(fields, fieldName, out string textValue, out errorMessage))
            {
                value = 0;
                return false;
            }

            if (!int.TryParse(textValue, out value))
            {
                errorMessage = $"Invalid recipe value: {fieldName} must be a number.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        private void SetupResultTable()
        {
            resultDataGridView.Rows.Clear();
            resultDataGridView.Columns.Clear();

            resultDataGridView.Columns.Add("Time", "Time");
            resultDataGridView.Columns.Add("ProductName", "Product Name");
            resultDataGridView.Columns.Add("Result", "Result");
            resultDataGridView.Columns.Add("Remark", "Remark");
        }

        private void AddSimulatedResultRow()
        {
            resultDataGridView.Rows.Add(
                DateTime.Now.ToString("HH:mm:ss"),
                _currentRecipe.ProductName,
                "OK",
                "Simulated Phase 4 result");
        }

        private void AddLogMessage(string message)
        {
            AddLogLine(message, Color.Black, FontStyle.Regular);
        }

        private void AddLogUpdateHeader(string actionName)
        {
            _logUpdateNumber++;

            if (logTextBox.TextLength > 0)
            {
                AddLogMessage(string.Empty);
            }

            // In equipment software, grouping logs by operation makes troubleshooting easier.
            string separator = new string('=', 60);
            AddLogLine(separator, Color.RoyalBlue, FontStyle.Bold);
            AddLogLine($"UPDATE #{_logUpdateNumber:000}", Color.RoyalBlue, FontStyle.Bold);
            AddLogLine($"Action : {actionName}", Color.RoyalBlue, FontStyle.Bold);
            AddLogLine($"Time   : {DateTime.Now:HH:mm:ss}", Color.RoyalBlue, FontStyle.Bold);
            AddLogLine($"State  : {_machineService.CurrentState}", Color.RoyalBlue, FontStyle.Bold);
            AddLogLine(separator, Color.RoyalBlue, FontStyle.Bold);
        }

        private void AddLogLine(string message, Color textColor, FontStyle fontStyle)
        {
            logTextBox.SelectionStart = logTextBox.TextLength;
            logTextBox.SelectionLength = 0;
            logTextBox.SelectionColor = textColor;
            logTextBox.SelectionFont = new Font(logTextBox.Font, fontStyle);
            logTextBox.AppendText(message + Environment.NewLine);
            logTextBox.SelectionColor = Color.Black;
            logTextBox.SelectionFont = logTextBox.Font;
            logTextBox.ScrollToCaret();
        }
    }
}
