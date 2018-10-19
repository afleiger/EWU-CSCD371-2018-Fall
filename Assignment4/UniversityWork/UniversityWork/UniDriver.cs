using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityWork
{
    public static class UniDriver
    {
        public static string Display(object @object)
        {
            switch(@object)
            {
                case CalendarItem item:
                    return item.GetSummaryInformation();
                    
                default:
                    return @object.ToString();
                    
            }
        }

        public static string DisplayCalendarItem(CalendarItem item)
        {
            return item.GetSummaryInformation();
        }
    }
}
