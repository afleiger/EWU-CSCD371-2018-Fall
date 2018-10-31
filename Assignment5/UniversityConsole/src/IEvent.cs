using System;
using System.Collections.Generic;
using System.Text;

namespace src
{
    public interface IEvent
    {
        string ID { get; set; }

        string Title { get; set; }

        string Location { get; set; }

        string GetSummaryInformation();
    }

    public static class Extensions
    {
        public static string DisplayInformation(this IEvent @event)
        {
            string ret = @event.GetSummaryInformation();

            return $"[{ret}]";
        }

        /// <summary>
        /// Calculates the character count of the title and location fields for no real reason.
        /// </summary>
        /// <param name="event"></param>
        /// <returns></returns>
        public static int InformationLength(this IEvent @event)
        {
            return @event.Title.Length + @event.Location.Length;
        }
    }
}
