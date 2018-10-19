using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityWork
{
    public abstract class CalendarItem
    {

        public string ID { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }

        public CalendarItem(string id = "", string title = "", string location = "")
        {
            ID = id;
            Title = title;
            Location = location;
        }

        public void Deconstruct(out string id, out string title, out string location)
        {
            id = ID;
            title = Title;
            location = Location;
        }
    }
}
