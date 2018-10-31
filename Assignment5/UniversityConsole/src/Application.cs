using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace src
{
    public class Application
    {
        
        private static readonly string newLine = Environment.NewLine;

        public static void Main()
        {
            IConsole con = new SystemConsole();
            List<IEvent> eventList = new List<IEvent>();
            string userInput = "";

            con.WriteLine("----------------University-Event-Calendar------------------------");

            do
            {
                DisplayMenu(con);
                userInput = GetMenuInput(con);

                switch (userInput)
                {
                    case "0":
                        con.WriteLine("Error: Not a valid option.");
                        break;
                    case "1":
                        DisplayEventList(eventList, con);
                        break;
                    case "2":
                        eventList.Add(CreateEvent(con));
                        break;
                }
            }
            while (userInput.ToLower() != "q");
        }

        public static void DisplayMenu(IConsole con)
        {
            con.Write($"{newLine}     1: View Calendar{newLine}     2: Add Event{newLine}('q' to quit)----->");
        }

        public static string GetMenuInput(IConsole con)
        {
            Regex rx = new Regex("[12q]", RegexOptions.IgnoreCase);

            string userIn = con.ReadLine().Trim();

            if(rx.IsMatch(userIn))
            {
                return userIn;
            }
            return "0";
        }

        public static void DisplayEventList(List<IEvent> eventList, IConsole con)
        {
            con.Write($"{newLine}");
            foreach (IEvent @event in eventList)
            {
                con.WriteLine(@event.DisplayInformation());
            }
        }

        public static IEvent CreateEvent(IConsole con)
        {
            con.WriteLine($"{newLine}-----------Create-An-Event---------------------");

            con.Write("ID Number ----->");
            string id = con.ReadLine().Trim();

            con.Write("Title ----->");
            string title = con.ReadLine().Trim();

            con.Write("Location ----->");
            string location = con.ReadLine().Trim();

            con.Write("Time ----->");
            string time = con.ReadLine().Trim();

            return new Event(id, title, location, time);
        }
    }
}
