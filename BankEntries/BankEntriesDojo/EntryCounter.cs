using System.Collections.Generic;
using BankEntriesDojo.Model;

namespace BankEntriesDojo.Application
{
    public static class EntryCounter
    {
        public static int Count(List<LogEntry> logEntries)
        {
            int count = 0;
            foreach(var entry in logEntries)
            {
                if(entry.Timestamp.Hour >= 10 && entry.Timestamp.Hour < 16)
                {
                    count++;
                }
            }
            return count;
        }
    }
}