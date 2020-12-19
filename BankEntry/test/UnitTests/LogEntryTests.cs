using System;
using NUnit.Framework;
using BankEntriesDojo.Model;

namespace BankEntriesDojo.Model.Tests
{
    public class LogEntryTests
    {
        [Test]
        public void ReturnFormattedString()
        {
            var logEntry = new LogEntry(new DateTime(2019, 10, 20, 10, 30, 00), "Entrei Galera!");
            var formatted = logEntry.ToString();
            var expected = "[2019-10-20 10:30:00] - Entrei Galera!";

            Assert.AreEqual(expected, formatted);
        }
    }
}