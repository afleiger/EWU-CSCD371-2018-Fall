using System;
using TimeTracker;

namespace Time.Tests
{
    public class TestDateTime : IDateTime
    {
        public string NowString => "This is Now!";

        public string EndString => "This is the End!";

        public string StartString => "This is the Start!";

        public TimeSpan CalcSpan()
        {
            return new TimeSpan(42,42,42,42);
        }

        public void EndTimer()
        {
            
        }

        public void StartTimer()
        {
            
        }
    }
}
