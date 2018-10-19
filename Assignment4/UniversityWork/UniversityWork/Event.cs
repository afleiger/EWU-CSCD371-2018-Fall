using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityWork
{
    public class Event : CalendarItem
    {

        private static int _instanceCount = 0;

        public string TimeInformation { get; set; }

        public static int InstanceCount
        {
            get
            {
                return _instanceCount;
            }
            set
            {
                _instanceCount = value;
            }
        }

        public Event(string id, string title, string location, string timeInformation)
            :base(id, title, location)
        {
            TimeInformation = timeInformation;
            InstanceCount++;
        }

        public string GetSummaryInformation()
        {
            return "";
        }
    }
}
