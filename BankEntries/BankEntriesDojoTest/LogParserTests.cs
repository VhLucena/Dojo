using NUnit.Framework;
using System.IO;
using BankEntriesDojo.Data;
using BankEntriesDojo.Model;
using System;
using System.Collections.Generic;

namespace BankEntriesDojo.Data.Tests
{
    public class LogParserTest
    {
        [Test]
        public void ReturnEmptyList_When_LogIsEmpty()
        {
            var logFile = new FileInfo("TestLogs.txt");

            var log = LogParser.Parse(logFile);

            Assert.AreEqual(0, log.Count);
        }

        [Test]
        public void ReturnListWithOneEntry_When_LogHasOneEntry()
        {
            // Arrange
            var logFile = new FileInfo("test.txt");
            
            var writer = logFile.CreateText();

            var logEntry = new LogEntry(DateTime.Now, "Comment");

            writer.Write(logEntry.ToString());
            writer.Close();
            
            // Act
            var log = LogParser.Parse(logFile);
            
            // Assert
            Assert.AreEqual(1, log.Count);
        }

        [Test]
        public void ReturnCorrectlyOneParsedEntry()
        {
            // Arrange
            var logFile = new FileInfo("test.txt");
                        
            var writer = logFile.CreateText();

            var logEntry = new LogEntry(new DateTime(2019, 10, 10, 17, 0, 0), "Comment");

            writer.Write(logEntry.ToString());
            writer.Close();

            // Act
            var log = LogParser.Parse(logFile);

            // Assert
            Assert.AreEqual(logEntry.ToString(), log[0].ToString());
        }

                [Test]
        public void ReturnCorrectlyFourParsedEntry()
        {
            // Arrange
            var logFile = new FileInfo("test.txt");
                        
            var writer = logFile.CreateText();

            var logEntries = new List<LogEntry>
            {
                new LogEntry(new DateTime(2019, 10, 10, 6, 0, 0), "Comment"),
                new LogEntry(new DateTime(2019, 12, 1, 17, 0, 0), ""),
                new LogEntry(new DateTime(2019, 9, 10, 17, 0, 1), "Comment With Space"),
                new LogEntry(new DateTime(2019, 6, 10, 9, 45, 0), "Comment Terminating With Special Caracatere %")
            };

            foreach(var logEntry in logEntries)
            {
                writer.WriteLine(logEntry.ToString());
            }
            
            writer.Close();

            // Act
            var log = LogParser.Parse(logFile);

            // Assert
            Assert.AreEqual(logEntries[0].ToString(), log[0].ToString());
            Assert.AreEqual(logEntries[1].ToString(), log[1].ToString());
            Assert.AreEqual(logEntries[2].ToString(), log[2].ToString());
            Assert.AreEqual(logEntries[3].ToString(), log[3].ToString());
        }
    }
}