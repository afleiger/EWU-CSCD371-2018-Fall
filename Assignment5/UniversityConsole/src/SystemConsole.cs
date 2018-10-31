using System;

namespace src
{
    public class SystemConsole : IConsole
    {
        public string LastWrittenLine { get; private set; }

        public void WriteLine(string txt)
        {
            Console.WriteLine(txt);
            LastWrittenLine = txt;
        }

        public void Write(string txt)
        {
            Console.Write(txt);
            LastWrittenLine = txt;
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
