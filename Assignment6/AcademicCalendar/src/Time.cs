using System;
using System.Collections.Generic;
using System.Text;

namespace src
{
    public struct Time
    {
        private static byte _hour;
        private static byte _minute;
        private static byte _second;

        public byte Hour
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
        public byte Minute
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
        public byte Second
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

        public Time(byte hour, byte minute, byte second)
        {
            Second = second;
            Minute = minute;
            Hour = hour;
        }
    }
}
