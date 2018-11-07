using System;
using System.Collections.Generic;
using System.Text;

namespace src
{
    public readonly struct Schedule
    {
        public DaysOfWeek Days { get; }
        public Quarters Quarter { get; }
        public Time StartTime { get; }
        public TimeSpan Duration { get; }


        public Schedule(DaysOfWeek days, Quarters quarter, Time startTime, TimeSpan duration)
        {
            Days = days;
            Quarter = quarter;
            StartTime = startTime;
            Duration = duration;
        }
    }
}
