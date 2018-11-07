using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace src
{
    public class Program
    {
        public static void Main()
        {
            //This only exists to determine sizes of Schedules
            
            Time t = new Time(12, 59, 59);
            MySchedule s = new MySchedule(DaysOfWeek.Friday, Quarters.Winter, t, TimeSpan.FromDays(1));

            Console.WriteLine($"{Marshal.SizeOf(s)}");
            Console.ReadLine();
        }
    }
}
