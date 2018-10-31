using src;

namespace UniversityConsole.Tests
{
    public class TestConsole : IConsole
    {
        public string LastWrittenLine { get; private set; }
        public string LineToRead { get; set; }

        public string ReadLine()
        {
            return LineToRead;
        }

        public void Write(string text)
        {
            LastWrittenLine = text;
        }

        public void WriteLine(string text)
        {
            LastWrittenLine = text;
        }
    }
}
