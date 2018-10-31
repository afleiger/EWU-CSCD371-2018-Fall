namespace src
{
    public interface IConsole
    { 
        string LastWrittenLine { get; }

        void WriteLine(string text);

        void Write(string text);

        string ReadLine();
    }
}
