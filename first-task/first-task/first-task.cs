using System;
using System.IO;

namespace First_task
{
    public abstract class LogBase
    {
        public abstract void Log(string message, string level);
    }

    public class Logger : LogBase
    {
        private readonly string _filePath;

        public Logger()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string fileName = "Log.txt";
            _filePath = Path.Combine(currentDirectory, fileName);
        }

        public override void Log(string message, string level)
        {
            string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{level}] {message}";

            Console.WriteLine(logEntry);
            using (StreamWriter w = File.AppendText(_filePath))
            {
                w.WriteLine(logEntry);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();
            logger.Log("User logged in", "INFO");
            logger.Log("Failed login attempt", "WARNING");
        }
    }
}