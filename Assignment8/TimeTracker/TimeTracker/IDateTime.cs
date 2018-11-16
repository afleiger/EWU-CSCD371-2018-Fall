using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker
{
    public interface IDateTime
    {
        string NowString { get; }
        string EndString { get; }
        string StartString { get; }
        TimeSpan CalcSpan();
        void StartTimer();
        void EndTimer();
    }
}
