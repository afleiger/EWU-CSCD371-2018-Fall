using System;
using System.Collections.Generic;
using System.Text;

namespace src
{
    [Flags]
    public enum DaysOfWeek
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 8,
        Friday = 16,
        Saturdday = 32,
        Sunday = 64
    }
}
