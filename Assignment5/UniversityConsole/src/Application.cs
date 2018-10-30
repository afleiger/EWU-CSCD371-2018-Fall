using System.Collections.Generic;
namespace src
{
    public static class Application
    {
        private static IConsole Console;
        public static void Main()
        {
            Console = new SystemConsole();

        }
    }
}
