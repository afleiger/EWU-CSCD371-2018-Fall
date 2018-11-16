using System;

namespace TimeTracker
{
    public class TimeManager
    {
        public Action<object, TimeArgs> UpdateEvent { get; set; }
        
        private IDateTime TimeSource { get; set; }

        public string SpanString
        {
            get
            {
                return TimeSource.CalcSpan().ToString();
            }
        }

        public string NowString
        {
            get
            {
                return TimeSource.NowString;
            }
        }

        public TimeManager(IDateTime timeSource)
        {
            TimeSource = timeSource;
        }

        public string StartTimer()
        {
            TimeSource.StartTimer();
            return $"{TimeSource.StartString}  ";
        }

        public void EndTimer()
        {
            TimeSource.EndTimer();
            string str = $"{TimeSource.StartString} -------- {TimeSource.EndString}      {SpanString}";
            UpdateEvent?.Invoke(this, new TimeArgs() { TimeString = str });
        }
    }
}
