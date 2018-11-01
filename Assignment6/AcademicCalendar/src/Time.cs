using System;
using System.Collections.Generic;
using System.Text;

namespace src
{
    public struct Time
    {
        private static int _hour;
        private static int _minute;
        private static int _second;

        public int Hour
        {
            get
            {
                return _hour;
            }
            private set
            {
                if(value > 0 && value < 25)
                {
                    _hour = value;
                }
            }
        }
        public int Minute
        {
            get
            {
                return _minute;
            }
            private set
            {
                if (value > 0 && value < 61)
                {
                    _minute = value;
                }
            }
        }
        public int Second
        {
            get
            {
                return _second;
            }
            private set
            {
                if (value > 0 && value < 61)
                {
                    _second = value;
                }
            }
        }

        public Time(int hour, int minute, int second)
        {
            Second = second;
            Minute = minute;
            Second = second;
        }
    }
}
