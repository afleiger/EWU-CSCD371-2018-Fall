using System;
using System.Collections.Generic;
using System.Text;

namespace src
{
    public class Event : CalendarItem
    {
        //-->Properties
        public string TimeInformation { get; set; }
        public static int InstanceCount { get; set; }
        //-->End Properties

        public Event(string id, string title, string location, string timeInformation = "")
            : base(id, title, location)
        {
            TimeInformation = timeInformation;
            InstanceCount++;
        }

        public override string GetSummaryInformation()
        {
            return $@"Id: {ID}        Title: {Title}      Location: {Location}        Time: {TimeInformation}";
        }

        public void Deconstruct(out string id, out string title, out string location, out string time)
        {
            (id, title, location) = this;
            time = TimeInformation;
        }
    }
}