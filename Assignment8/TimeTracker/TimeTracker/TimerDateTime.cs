using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker
{
    public class TimerDateTime : IDateTime
    {
        private DateTime Start { get; set; }
        private DateTime End { get; set; }
        public string EndString
        {
            get
            {
                return End.ToLongTimeString();
            }
        }

        public string StartString
        {
            get
            {
                return Start.ToLongTimeString();
            }
        }

        public string NowString
        {
            get
            {
                return DateTime.Now.ToLongTimeString();
            }
        }

        public TimeSpan CalcSpan()
        {
            return End - Start;
        }

        public void StartTimer()
        {
            Start = DateTime.Now;
        }

        public void EndTimer()
        {
            End = DateTime.Now;
        }
    }
}
