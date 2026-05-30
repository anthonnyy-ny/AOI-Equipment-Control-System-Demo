using AOIEquipmentControlSystem.Services;

namespace AOIEquipmentControlSystem
{
    public partial class MainForm : Form
    {
        private readonly MachineService _machineService;
        private int _logUpdateNumber;

        public MainForm()
        {
            InitializeComponent();

            _machineService = new MachineService(new LoggerService());

            ShowRecipeParameters();
            SetupResultTable();
            UpdateMachineStatus();
            AddLogUpdateHeader("System Startup");
            AddLogMessage("Application started.");
        }

        private void InitializeButton_Click(object sender, EventArgs e)
        {
            RunMachineAction("Initialize", _machineService.Initialize());
        }

        private void StartAutoButton_Click(object sender, EventArgs e)
        {
            RunMachineAction("Start Auto", _machineService.StartAuto());

            if (_machineService.CurrentState == Models.MachineState.Ready)
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
        }

        private void ShowRecipeParameters()
        {
            recipeTextBox.Text =
                "ProductName: Lens_Module_A" + Environment.NewLine +
                "ExposureTime: 120" + Environment.NewLine +
                "Threshold: 85" + Environment.NewLine +
                "MinArea: 5000";
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
                "Lens_Module_A",
                "OK",
                "Simulated Phase 2 result");
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
