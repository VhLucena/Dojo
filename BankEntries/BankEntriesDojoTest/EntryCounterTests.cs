using NUnit.Framework;
using System;
using System.Collections.Generic;
using BankEntriesDojo.Model;
using BankEntriesDojo.Application;

namespace BankEntriesDojo.Application.Tests
{
    public class EntryCounterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReturnZero_When_ListIsEmpty()
        {
            var emptyList = new List<LogEntry>();

            var count = EntryCounter.Count(emptyList);

            Assert.AreEqual(count, 0);
        }

        [Test]
        public void ReturnOne_When_ListContainsOneEntryBetween10HAnd16H()
        {
            var entry = new LogEntry(new DateTime(2019, 09, 01, 11, 00, 00), "Abertura da Porta OK");
            
            var entries = new List<LogEntry> { entry };

            var count = EntryCounter.Count(entries);

            Assert.AreEqual(count, 1);
        }

        [Test]
        public void ReturnZero_When_ListIsntEmptyButContainsNoEntryBetween10HAnd16H()
        {
            var entry = new LogEntry(new DateTime(2019, 09, 01, 09, 00, 00), "Abertura da Porta OK");
            
            var entries = new List<LogEntry> { entry };

            var count = EntryCounter.Count(entries);

            Assert.AreEqual(count, 0);
        }

        [Test]
        public void RaiseException_When_NullList()
        {
            List<LogEntry> nullEntries = null;

            Assert.Throws<NullReferenceException>(() => EntryCounter.Count(nullEntries));
        }
    }
}