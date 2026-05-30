using AOIEquipmentControlSystem.Services;

namespace AOIEquipmentControlSystem
{
    public partial class MainForm : Form
    {
        private readonly MachineService _machineService;

        public MainForm()
        {
            InitializeComponent();

            _machineService = new MachineService(new LoggerService());

            ShowRecipeParameters();
            SetupResultTable();
            UpdateMachineStatus();
            AddLogMessage("Application started.");
        }

        private void InitializeButton_Click(object sender, EventArgs e)
        {
            RunMachineAction(_machineService.Initialize());
        }

        private void StartAutoButton_Click(object sender, EventArgs e)
        {
            RunMachineAction(_machineService.StartAuto());

            if (_machineService.CurrentState == Models.MachineState.Ready)
            {
                AddSimulatedResultRow();
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            RunMachineAction(_machineService.Stop());
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            RunMachineAction(_machineService.Reset());
        }

        private void ClearAlarmButton_Click(object sender, EventArgs e)
        {
            RunMachineAction(_machineService.ClearAlarm());
        }

        private void RunMachineAction(List<string> logs)
        {
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
            logTextBox.AppendText(message + Environment.NewLine);
        }
    }
}
