using System;
using System.IO;
using BankEntriesDojo.Application;
using BankEntriesDojo.Data;

namespace BankEntriesDojo
{
    class Program
    {
        static void Main(string[] args)
        {
            var logFile = new FileInfo("entrylog.txt");
            
            var log = LogParser.Parse(logFile);
            
            var count = EntryCounter.Count(log);

            System.Console.WriteLine(count);
        }
    }
}
