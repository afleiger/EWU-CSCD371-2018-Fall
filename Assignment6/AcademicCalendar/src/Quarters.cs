using System;
using System.Collections.Generic;
using System.Text;

namespace src
{
    [Flags]
    public enum Quarters : byte
    {
        Fall = 1,
        Winter = 2,
        Spring = 4,
        Summer = 8
    }
}
