using System;
using System.IO;
using First_task;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace First_task.tests
{
    public class UnitTests
    {
        private readonly string _testFilePath;

        public UnitTests()
        {
            _testFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Log.txt");
        }
        [Fact]
        public void InfoCorrectly()
        {
            // Arrange
            var logger = new Logger();
            string testMessage = "Test info message";

            // Act
            logger.Log(testMessage, "INFO");

            // Assert
            string[] logContents = File.ReadAllLines(_testFilePath);
            Assert.Contains(logContents, entry => entry.Contains(testMessage) && entry.Contains("INFO"));
        }
        [Fact]
        public void CorrectTimeInfo()
        {
            // Arrange
            var logger = new Logger();

            // Act
            logger.Log("", "INFO");

            // Assert
            string[] logContents = File.ReadAllLines(_testFilePath);
            string logEntry = logContents[logContents.Length - 1]; // Get the last log entry
            DateTime logTimestamp = DateTime.ParseExact(logEntry.Substring(1, 19), "yyyy-MM-dd HH:mm:ss", null);

            // Allow a small time window (e.g., 1 second) for timestamp comparison
            TimeSpan tolerance = TimeSpan.FromSeconds(1);
            DateTime expectedMinTime = DateTime.Now.Subtract(tolerance);
            DateTime expectedMaxTime = DateTime.Now.Add(tolerance);

            Assert.InRange(logTimestamp, expectedMinTime, expectedMaxTime);
        }
    

    [Fact]
    public void WarningCorrectly()
    {
        // Arrange
        var logger = new Logger();
        string testMessage = "Test info message";

        // Act
        logger.Log(testMessage, "Warning");

        // Assert
        string[] logContents = File.ReadAllLines(_testFilePath);
        Assert.Contains(logContents, entry => entry.Contains(testMessage) && entry.Contains("INFO"));
    }
    [Fact]
    public void CorrectTimeWarning()
    {
        // Arrange
        var logger = new Logger();

        // Act
        logger.Log("", "Warning");

        // Assert
        string[] logContents = File.ReadAllLines(_testFilePath);
        string logEntry = logContents[logContents.Length - 1]; // Get the last log entry
        DateTime logTimestamp = DateTime.ParseExact(logEntry.Substring(1, 19), "yyyy-MM-dd HH:mm:ss", null);

        TimeSpan tolerance = TimeSpan.FromSeconds(1);
        DateTime expectedMinTime = DateTime.Now.Subtract(tolerance);
        DateTime expectedMaxTime = DateTime.Now.Add(tolerance);

        Assert.InRange(logTimestamp, expectedMinTime, expectedMaxTime);
    }
}
}
