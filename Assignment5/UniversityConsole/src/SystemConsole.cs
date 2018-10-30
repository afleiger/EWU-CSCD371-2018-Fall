using System;
using System.Collections.Generic;
using System.Text;

namespace src
{
    public class SystemConsole : IConsole
    {
        public string LastWrittenLine { get; set; }

        public void WriteLine(string txt)
        {
            Console.WriteLine(txt);
            LastWrittenLine = txt;
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }


    }
}
