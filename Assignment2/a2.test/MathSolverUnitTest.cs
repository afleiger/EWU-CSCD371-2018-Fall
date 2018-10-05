using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntelliTect.TestTools.Console;
using System;

namespace MathSolver.test
{
    [TestClass]
    public class MathSolverUnitTest
    {
        static String introText = ">>Enter a problem: ";

        [TestMethod]
        public void AddingPositiveNumbers()
        {
            String testExpression = "2+2";
            String expectedAnswer = "4";

            ConsoleAssert.Expect(introText + $@"
<<{testExpression}
>>Output: {expectedAnswer}", SimpleMathSolver.SimpleMathSolver.Main);
        }

        [TestMethod]
        public void AddingNegativeeNumbers()
        {
            String testExpression = "-2+-2";
            String expectedAnswer = "-4";

            ConsoleAssert.Expect(introText + $@"
<<{testExpression}
>>Output: {expectedAnswer}", SimpleMathSolver.SimpleMathSolver.Main);
        }

        [TestMethod]
        public void AddingMixedNumbers()
        {
            String testExpression = "-2+2";
            String expectedAnswer = "0";

            ConsoleAssert.Expect(introText + $@"
<<{testExpression}
>>Output: {expectedAnswer}", SimpleMathSolver.SimpleMathSolver.Main);
        }

        [TestMethod]
        public void AddingMixedNumbers2()
        {
            String testExpression = "2+-2";
            String expectedAnswer = "0";

            ConsoleAssert.Expect(introText + $@"
<<{testExpression}
>>Output: {expectedAnswer}", SimpleMathSolver.SimpleMathSolver.Main);
        }

        [TestMethod]
        public void SubtractNumbers()
        {
            String testExpression = "42-40";
            String expectedAnswer = "2";

            ConsoleAssert.Expect(introText + $@"
<<{testExpression}
>>Output: {expectedAnswer}", SimpleMathSolver.SimpleMathSolver.Main);
        }

        [TestMethod]
        public void SubtractingNegativeNumbers()
        {
            String testExpression = "-532--70";
            String expectedAnswer = "-462";

            ConsoleAssert.Expect(introText + $@"
<<{testExpression}
>>Output: {expectedAnswer}", SimpleMathSolver.SimpleMathSolver.Main);
        }

        [TestMethod]
        public void SubtractingMixedNumbers()
        {
            String testExpression = "-532-70";
            String expectedAnswer = "-602";

            ConsoleAssert.Expect(introText + $@"
<<{testExpression}
>>Output: {expectedAnswer}", SimpleMathSolver.SimpleMathSolver.Main);
        }

        [TestMethod]
        public void SubtractingMixedNumbers2()
        {
            String testExpression = "532--70";
            String expectedAnswer = "602";

            ConsoleAssert.Expect(introText + $@"
<<{testExpression}
>>Output: {expectedAnswer}", SimpleMathSolver.SimpleMathSolver.Main);
        }

        [TestMethod]
        public void MultiplyNumbers()
        {
            String testExpression = "12*5";
            String expectedAnswer = "60";

            ConsoleAssert.Expect(introText + $@"
<<{testExpression}
>>Output: {expectedAnswer}", SimpleMathSolver.SimpleMathSolver.Main);
        }

        [TestMethod]
        public void MultiplyNegativeNumbers()
        {
            String testExpression = "-80*-40.6";
            String expectedAnswer = "3248";

            ConsoleAssert.Expect(introText + $@"
<<{testExpression}
>>Output: {expectedAnswer}", SimpleMathSolver.SimpleMathSolver.Main);
        }

        [TestMethod]
        public void MultiplyMixedNumbers()
        {
            String testExpression = "33*-2";
            String expectedAnswer = "-66";

            ConsoleAssert.Expect(introText + $@"
<<{testExpression}
>>Output: {expectedAnswer}", SimpleMathSolver.SimpleMathSolver.Main);
        }

        [TestMethod]
        public void DivideNumbers()
        {
            String testExpression = "30/2";
            String expectedAnswer = "15";

            ConsoleAssert.Expect(introText + $@"
<<{testExpression}
>>Output: {expectedAnswer}", SimpleMathSolver.SimpleMathSolver.Main);
        }

        [TestMethod]
        public void DivideNegativeNumbers()
        {
            String testExpression = "50/-.5";
            String expectedAnswer = "-100";

            ConsoleAssert.Expect(introText + $@"
<<{testExpression}
>>Output: {expectedAnswer}", SimpleMathSolver.SimpleMathSolver.Main);
        }

        [TestMethod]
        public void DivideByZero()
        {
            String testExpression = "67/0";
            String expectedAnswer = "Error -- Divide by zero.";

            ConsoleAssert.Expect(introText + $@"
<<{testExpression}
>>Output: {expectedAnswer}", SimpleMathSolver.SimpleMathSolver.Main);
        }

        [TestMethod]
        public void EnterGarbage()
        {
            String testExpression = "35235fgveve - ini2  ";
            String expectedAnswer = "Formatting Error -- Please submit in {Value}{Operator}{Value} form.";

            ConsoleAssert.Expect(introText + $@"
<<{testExpression}
>>Output: {expectedAnswer}", SimpleMathSolver.SimpleMathSolver.Main);
        }

        [TestMethod]
        public void TestWhiteSpace()
        {
            String testExpression = "75     *                    -3";
            String expectedAnswer = "-225";

            ConsoleAssert.Expect(introText + $@"
<<{testExpression}
>>Output: {expectedAnswer}", SimpleMathSolver.SimpleMathSolver.Main);
        }

        [TestMethod]
        public void Exponents()
        {
            String testExpression = "2^8";
            String expectedAnswer = "256";

            ConsoleAssert.Expect(introText + $@"
<<{testExpression}
>>Output: {expectedAnswer}", SimpleMathSolver.SimpleMathSolver.Main);
        }

        [TestMethod]
        public void NegativeExponents()
        {
            String testExpression = "4^-2";
            String expectedAnswer = "0.0625";

            ConsoleAssert.Expect(introText + $@"
<<{testExpression}
>>Output: {expectedAnswer}", SimpleMathSolver.SimpleMathSolver.Main);
        }

        [TestMethod]
        public void NegativeBaseExponents()
        {
            String testExpression = "-2^7";
            String expectedAnswer = "-128";

            ConsoleAssert.Expect(introText + $@"
<<{testExpression}
>>Output: {expectedAnswer}", SimpleMathSolver.SimpleMathSolver.Main);
        }

        [TestMethod]
        public void Modulus()
        {
            String testExpression = "57 % 10";
            String expectedAnswer = "7";

            ConsoleAssert.Expect(introText + $@"
<<{testExpression}
>>Output: {expectedAnswer}", SimpleMathSolver.SimpleMathSolver.Main);
        }

        [TestMethod]
        public void ModulusByZero()
        {
            String testExpression = "42 % 0";
            String expectedAnswer = "NaN";

            ConsoleAssert.Expect(introText + $@"
<<{testExpression}
>>Output: {expectedAnswer}", SimpleMathSolver.SimpleMathSolver.Main);
        }

        [TestMethod]
        public void MaxIntValues()
        {
            String testExpression = int.MaxValue + " - " + int.MaxValue;
            String expectedAnswer = "0";

            ConsoleAssert.Expect(introText + $@"
<<{testExpression}
>>Output: {expectedAnswer}", SimpleMathSolver.SimpleMathSolver.Main);
        }
    }
}