using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker
{
    public class TimeArgs : EventArgs
    {
        public string TimeString { get; set; }
    }
}
