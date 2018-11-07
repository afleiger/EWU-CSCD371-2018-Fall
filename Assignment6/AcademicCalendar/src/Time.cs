using System;
using System.Collections.Generic;
using System.Text;

namespace src
{
    public readonly struct Time
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
                if(value >= 0 && value < 24)
                {
                    _hour = value;
                }
                else
                {
                    _hour = 0;
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
                if (value >= 0 && value < 60)
                {
                    _minute = value;
                }
                else
                {
                    _minute = 0;
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
                if (value >= 0 && value < 60)
                {
                    _second = value;
                }
                else
                {
                    _second = 0;
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
