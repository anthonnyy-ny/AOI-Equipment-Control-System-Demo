using AOIEquipmentControlSystem.Models;

namespace AOIEquipmentControlSystem.Services
{
    public class MachineService
    {
        private readonly LoggerService _loggerService;

        public MachineState CurrentState { get; private set; } = MachineState.Idle;
        public bool IsDeviceConnected { get; private set; }
        public string CurrentAlarmMessage { get; private set; } = string.Empty;

        public MachineService(LoggerService loggerService)
        {
            _loggerService = loggerService;
        }

        public List<string> Initialize()
        {
            List<string> logs = new();

            AddInfoLog("Step 1/5 - Check system idle.", logs);

            if (CurrentState != MachineState.Idle)
            {
                AddInvalidOperationLog("Initialize requires Idle state.", logs);
                return logs;
            }

            TryChangeState(MachineState.Initializing, logs);

            // In real equipment software, these steps would talk to hardware.
            // Phase 4 still simulates the flow, but logs each equipment step clearly.
            AddInfoLog("Step 2/5 - Connect device.", logs);
            IsDeviceConnected = true;
            AddInfoLog("Device connected.", logs);
            AddInfoLog("Step 3/5 - Load recipe.", logs);
            AddInfoLog("Step 4/5 - Home axis.", logs);

            TryChangeState(MachineState.Ready, logs);
            AddInfoLog("Step 5/5 - Machine ready.", logs);

            return logs;
        }

        public List<string> StartAuto()
        {
            List<string> logs = new();

            AddInfoLog("Step 1/7 - Check machine ready.", logs);

            if (CurrentState != MachineState.Ready)
            {
                AddInvalidOperationLog("Start Auto requires Ready state.", logs);
                SetAlarm(GetStartAutoAlarmMessage(), logs);
                return logs;
            }

            CurrentAlarmMessage = string.Empty;

            TryChangeState(MachineState.Running, logs);
            AddInfoLog("Start auto inspection flow.", logs);

            AddInfoLog("Step 2/7 - Move to capture position.", logs);
            AddInfoLog("Step 3/7 - Turn on light.", logs);
            AddInfoLog("Step 4/7 - Capture image.", logs);

            TryChangeState(MachineState.Inspecting, logs);
            AddInfoLog("Step 5/7 - Run inspection.", logs);

            TryChangeState(MachineState.Completed, logs);
            AddInfoLog("Step 6/7 - Save result (simulated).", logs);
            AddInfoLog("Step 7/7 - Complete cycle.", logs);

            TryChangeState(MachineState.Ready, logs);
            AddInfoLog("Machine is ready for next run.", logs);

            return logs;
        }

        public List<string> Stop()
        {
            List<string> logs = new();

            if (CurrentState == MachineState.Alarm)
            {
                AddInfoLog("Stop ignored because machine is in Alarm. Clear alarm or reset first.", logs);
                return logs;
            }

            if (CurrentState == MachineState.Ready ||
                CurrentState == MachineState.Running ||
                CurrentState == MachineState.Inspecting)
            {
                TryChangeState(MachineState.Stopped, logs);
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
            CurrentAlarmMessage = string.Empty;
            TryChangeState(MachineState.Idle, logs);
            AddInfoLog("Machine reset to Idle.", logs);

            return logs;
        }

        public List<string> ClearAlarm()
        {
            List<string> logs = new();

            if (CurrentState == MachineState.Alarm)
            {
                CurrentAlarmMessage = string.Empty;
                TryChangeState(MachineState.Idle, logs);
                AddInfoLog("Alarm cleared.", logs);
                return logs;
            }

            AddInfoLog("No alarm to clear.", logs);
            return logs;
        }

        private bool TryChangeState(MachineState newState, List<string> logs)
        {
            if (CurrentState == newState)
            {
                return true;
            }

            if (!CanTransitionTo(newState))
            {
                AddErrorLog($"Invalid state transition: {CurrentState} -> {newState}.", logs);
                return false;
            }

            MachineState oldState = CurrentState;
            CurrentState = newState;

            // State changes are important machine events, so every change is logged.
            AddInfoLog($"Machine state changed: {oldState} -> {newState}", logs);
            return true;
        }

        private bool CanTransitionTo(MachineState newState)
        {
            if (newState == MachineState.Alarm)
            {
                return true;
            }

            if (newState == MachineState.Idle)
            {
                return true;
            }

            return CurrentState switch
            {
                MachineState.Idle => newState == MachineState.Initializing,
                MachineState.Initializing => newState == MachineState.Ready,
                MachineState.Ready => newState == MachineState.Running ||
                                      newState == MachineState.Stopped,
                MachineState.Running => newState == MachineState.Inspecting ||
                                        newState == MachineState.Stopped,
                MachineState.Inspecting => newState == MachineState.Completed ||
                                           newState == MachineState.Stopped,
                MachineState.Completed => newState == MachineState.Ready,
                _ => false
            };
        }

        private void SetAlarm(string alarmMessage, List<string> logs)
        {
            CurrentAlarmMessage = alarmMessage;
            TryChangeState(MachineState.Alarm, logs);
            AddErrorLog($"ALARM: {alarmMessage}", logs);
        }

        private string GetStartAutoAlarmMessage()
        {
            if (CurrentState == MachineState.Alarm)
            {
                return "Cannot start auto while alarm is active.";
            }

            if (CurrentState == MachineState.Stopped)
            {
                return "Cannot start auto from Stopped state. Please reset the machine first.";
            }

            return "Cannot start auto. Machine is not ready.";
        }

        private void AddInvalidOperationLog(string message, List<string> logs)
        {
            AddErrorLog($"Invalid operation: {message}", logs);
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
