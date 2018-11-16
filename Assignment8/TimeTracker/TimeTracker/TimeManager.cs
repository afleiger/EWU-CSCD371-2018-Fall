using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace TimeTracker
{
    public class TimeManager
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime Now
        {
            get
            {
                return DateTime.Now;
            }
        }
        public string NowString
        {
            get
            {
                return Now.ToLongTimeString();
            }
        }

        public string StartTimer()
        {
            Start = Now;
            return $"{Start.ToLongTimeString()}  ";
        }

        public string EndTimer()
        {
            End = Now;
            return $"{Start.ToLongTimeString()} -------- {End.ToLongTimeString()}      {TimerTime()}";
        }

        private string TimerTime()
        {
            TimeSpan span = End - Start;
            return $"{span.Hours}:{span.Minutes}:{span.Seconds}";
        }
    }
}
