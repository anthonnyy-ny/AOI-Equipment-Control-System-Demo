namespace AOIEquipmentControlSystem.Services
{
    public class LoggerService
    {
        private readonly string _logFolderPath;

        public LoggerService()
        {
            _logFolderPath = GetDefaultLogFolderPath();

            if (!Directory.Exists(_logFolderPath))
            {
                Directory.CreateDirectory(_logFolderPath);
            }
        }

        public string WriteLog(string level, string message)
        {
            string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{level}] {message}";
            string logFileName = $"{DateTime.Now:yyyy-MM-dd}_machine_log.txt";
            string logFilePath = Path.Combine(_logFolderPath, logFileName);

            File.AppendAllText(logFilePath, logMessage + Environment.NewLine);

            return logMessage;
        }

        public string Info(string message)
        {
            return WriteLog("INFO", message);
        }

        public string Error(string message)
        {
            return WriteLog("ERROR", message);
        }

        public string Result(string message)
        {
            return WriteLog("RESULT", message);
        }

        private static string GetDefaultLogFolderPath()
        {
            DirectoryInfo? currentDirectory = new(AppDomain.CurrentDomain.BaseDirectory);

            while (currentDirectory != null)
            {
                string projectFilePath = Path.Combine(currentDirectory.FullName, "AOIEquipmentControlSystem.csproj");
                string projectLogFolderPath = Path.Combine(currentDirectory.FullName, "Logs");

                if (File.Exists(projectFilePath))
                {
                    return projectLogFolderPath;
                }

                currentDirectory = currentDirectory.Parent;
            }

            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
        }
    }
}
