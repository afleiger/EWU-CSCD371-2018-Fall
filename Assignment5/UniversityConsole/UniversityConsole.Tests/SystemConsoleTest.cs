using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using IntelliTect.TestTools.Console;
using src;

namespace UniversityConsole.Tests
{
    [TestClass]
    public class SystemConsoleTest
    {
        [TestMethod]
        public void WriteLine_CallMethod_Success()
        {
            string str = "testinput";
            SystemConsole Console = new SystemConsole();

            ConsoleAssert.Expect($">>{str}", () => Console.WriteLine(str));
        }

        [TestMethod]
        public void Write_CallMethod_Success()
        {
            string str = "testinput";
            SystemConsole Console = new SystemConsole();

            ConsoleAssert.Expect($">>{str}", () => Console.Write(str));
        }

        [TestMethod]
        public void ReadLine_CallMethod_NothingBreaks()
        {
            ConsoleAssert.Expect("<<testinput", () => Console.ReadLine());
        }
    }
}
