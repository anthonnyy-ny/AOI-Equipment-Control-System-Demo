using AOIEquipmentControlSystem.Models;

namespace AOIEquipmentControlSystem.Services
{
    public class MachineService
    {
        private readonly LoggerService _loggerService;

        public MachineState CurrentState { get; private set; } = MachineState.Idle;
        public bool IsDeviceConnected { get; private set; }

        public MachineService(LoggerService loggerService)
        {
            _loggerService = loggerService;
        }

        public List<string> Initialize()
        {
            List<string> logs = new();

            ChangeState(MachineState.Initializing, logs);
            AddInfoLog("Initializing machine...", logs);

            // In real equipment software, these steps would talk to hardware.
            // Phase 2 only simulates the flow and keeps the logic easy to read.
            AddInfoLog("Loading recipe...", logs);
            AddInfoLog("Connecting device...", logs);
            IsDeviceConnected = true;
            AddInfoLog("Device connected.", logs);
            AddInfoLog("Homing motion axis...", logs);

            ChangeState(MachineState.Ready, logs);
            AddInfoLog("Machine is ready.", logs);

            return logs;
        }

        public List<string> StartAuto()
        {
            List<string> logs = new();

            if (CurrentState != MachineState.Ready)
            {
                ChangeState(MachineState.Alarm, logs);
                AddErrorLog("Cannot start auto. Machine is not ready.", logs);
                return logs;
            }

            ChangeState(MachineState.Running, logs);
            AddInfoLog("Start auto inspection flow.", logs);

            AddInfoLog("Moving to capture position...", logs);
            AddInfoLog("Turning light on...", logs);
            AddInfoLog("Capturing image...", logs);

            ChangeState(MachineState.Inspecting, logs);
            AddInfoLog("Running simulated inspection...", logs);

            ChangeState(MachineState.Completed, logs);
            AddInfoLog("Inspection flow completed.", logs);

            ChangeState(MachineState.Ready, logs);
            AddInfoLog("Machine is ready for next run.", logs);

            return logs;
        }

        public List<string> Stop()
        {
            List<string> logs = new();

            if (CurrentState == MachineState.Ready ||
                CurrentState == MachineState.Running ||
                CurrentState == MachineState.Inspecting)
            {
                ChangeState(MachineState.Stopped, logs);
                AddInfoLog("Machine stopped.", logs);
                return logs;
            }

            AddInfoLog("Stop ignored because machine is not running.", logs);
            return logs;
        }

        public List<string> Reset()
        {
            List<string> logs = new();

            IsDeviceConnected = false;
            ChangeState(MachineState.Idle, logs);
            AddInfoLog("Machine reset to Idle.", logs);

            return logs;
        }

        public List<string> ClearAlarm()
        {
            List<string> logs = new();

            if (CurrentState == MachineState.Alarm)
            {
                ChangeState(MachineState.Idle, logs);
                AddInfoLog("Alarm cleared.", logs);
                return logs;
            }

            AddInfoLog("No alarm to clear.", logs);
            return logs;
        }

        private void ChangeState(MachineState newState, List<string> logs)
        {
            CurrentState = newState;

            // State changes are important machine events, so every change is logged.
            AddInfoLog($"Machine state changed to {newState}.", logs);
        }

        private void AddInfoLog(string message, List<string> logs)
        {
            logs.Add(_loggerService.Info(message));
        }

        private void AddErrorLog(string message, List<string> logs)
        {
            logs.Add(_loggerService.Error(message));
        }
    }
}
