using System;

namespace src
{
    public interface IConsole
    { 
        string LastWrittenLine { get; }

        void WriteLine(string text);

        string ReadLine();
    }
}
