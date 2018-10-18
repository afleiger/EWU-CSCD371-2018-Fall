using System;

namespace CalendarItem
{
    public class CalendarItem
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public CalendarItem(int id, string title)
        {
            ID = id;
            Title = title;
        }

        public string GetSummaryInformation()
        {
            return $"Id: {ID}" + Environment.NewLine + $"Title: {Title}";
        }
    }
}