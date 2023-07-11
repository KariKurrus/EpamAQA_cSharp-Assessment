using System.Runtime.CompilerServices;

namespace EpamAQA_cSharp_Assessment
{
    public static class TextLogger
    {
        private static string _logFolderPath;
        private static string _logFilePath;
        private static readonly object _lockObject = new object();

        static TextLogger()
        {
            var fileName = "Logs.txt";
            var _workPath = Directory.GetParent(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"\..\..\..\")).ToString();
            _logFolderPath = Path.Combine(_workPath, "Logs");
            _logFilePath = Path.Combine(_logFolderPath, fileName);
        }

        public static async Task GenerateLogMessage(string logMessage)
        {
            using (StreamWriter writetext = new StreamWriter(_logFilePath, true))
            {
                writetext.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd H-m")}:{logMessage}");
            }
        }

        public static string GetmethodCaller([CallerMemberName] string callerName = "")
        {
            return callerName;
        }
    }
}
