using System;

namespace BankEntriesDojo.Model
{
    public class LogEntry
    {
        public DateTime Timestamp { get; private set; }
        public String Comment { get; private set; }

        public LogEntry(DateTime timestamp, String comment)
        {
            Timestamp = timestamp;
            Comment = comment;
        }

        public override string ToString()
        {
            return String.Format("[{0}-{1}-{2} {3}:{4}:{5}] - {6}",            
                Timestamp.Year,
                Timestamp.Month.ToString().PadLeft(2, '0'),
                Timestamp.Day.ToString().PadLeft(2, '0'),
                Timestamp.Hour.ToString().PadLeft(2, '0'),
                Timestamp.Minute.ToString().PadLeft(2, '0'),
                Timestamp.Second.ToString().PadLeft(2, '0'),
                Comment);
        }
        
    }
}
