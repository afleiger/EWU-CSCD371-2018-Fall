using System;
using System.Collections.Generic;
using System.Text;

namespace src
{
    public struct Schedule
    {
        private static DaysOfWeek _days;


        public Schedule(DaysOfWeek days)
        {
            _days = DaysOfWeek.Monday | DaysOfWeek.Tuesday | DaysOfWeek.Wednesday;
        }
    }
}
