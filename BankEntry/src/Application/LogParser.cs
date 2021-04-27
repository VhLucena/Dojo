using System;
using System.IO;
using System.Collections.Generic;
using BankEntriesDojo.Model;

namespace BankEntriesDojo.Data
{
    public static class LogParser
    {
        public static List<LogEntry> Parse (FileInfo logFile)
        {
            var log = new List<LogEntry>();
            var stream = logFile.OpenRead();

            using (var reader = new StreamReader(stream))
            {
                while (reader.Peek() != -1)
                {
                    var entryString = reader.ReadLine();

                    int year   = int.Parse(entryString.Substring(1,4));
                    int month  = int.Parse(entryString.Substring(6,2));
                    int day    = int.Parse(entryString.Substring(9,2));
                    int hour   = int.Parse(entryString.Substring(12,2));
                    int minute = int.Parse(entryString.Substring(15,2));
                    int second = int.Parse(entryString.Substring(18,2));

                    var comment = entryString.Substring(24);

                    log.Add(new LogEntry(new DateTime(year, month, day, hour, minute, second), comment));
                }
            }
            
            return log;
        }
    }
}