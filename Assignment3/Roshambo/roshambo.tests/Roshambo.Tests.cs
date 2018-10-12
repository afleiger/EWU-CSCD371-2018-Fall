using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntelliTect.TestTools.Console;
using System;
using System.Text;
using System.IO;

namespace Roshambo.Tests
{
    [TestClass]
    public class RoshamboUnitTest
    {
        [TestMethod]
        public void RandomChoice_ReturnsValid()
        {
            //arrange
            //act
            for (int x = 0; x < 100; x++)
            {
                string choice = Roshambo.RandomChoice();
                //assert
                Assert.IsTrue(choice == "rock" || choice == "scissors" || choice == "paper");
            }
        }

        [TestMethod]
        public void DetermineDamage_RockScissorsWin_ZeroDamageTaken()
        {
            //arrange
            (string player, string comp) round;
            round.player = "rock";
            round.comp = "scissors";
            //act
            int damageTaken = Roshambo.DetermineDamage(round.player, round.comp);
            //assert
            Assert.AreEqual(damageTaken, 0);
        }

        [TestMethod]
        public void DetermineDamage_RockPaperLose_TenDamageTaken()
        {
            //arrange
            (string player, string comp) round;
            round.player = "rock";
            round.comp = "paper";
            //act
            int damageTaken = Roshambo.DetermineDamage(round.player, round.comp);
            //assert
            Assert.AreEqual(damageTaken, 10);
        }

        [TestMethod]
        public void DetermineDamage_RockRockDraw_ZeroDamageTaken()
        {
            //arrange
            (string player, string comp) round;
            round.player = "rock";
            round.comp = "rock";
            //act
            int damageTaken = Roshambo.DetermineDamage(round.player, round.comp);
            //assert
            Assert.AreEqual(damageTaken, 0);
        }

        [TestMethod]
        public void DetermineDamage_ScissorsPaperWin_ZeroDamageTaken()
        {
            //arrange
            (string player, string comp) round;
            round.player = "scissors";
            round.comp = "paper";
            //act
            int damageTaken = Roshambo.DetermineDamage(round.player, round.comp);
            //assert
            Assert.AreEqual(damageTaken, 0);
        }

        [TestMethod]
        public void DetermineDamage_ScissorsRockLose_TwentyDamageTaken()
        {
            //arrange
            (string player, string comp) round;
            round.player = "scissors";
            round.comp = "rock";
            //act
            int damageTaken = Roshambo.DetermineDamage(round.player, round.comp);
            //assert
            Assert.AreEqual(damageTaken, 20);
        }

        [TestMethod]
        public void DetermineDamage_ScissorsScissorsDraw_ZeroDamageTaken()
        {
            //arrange
            (string player, string comp) round;
            round.player = "scissors";
            round.comp = "scissors";
            //act
            int damageTaken = Roshambo.DetermineDamage(round.player, round.comp);
            //assert
            Assert.AreEqual(damageTaken, 0);
        }

        [TestMethod]
        public void DetermineDamage_PaperRockWin_ZeroDamageTaken()
        {
            //arrange
            (string player, string comp) round;
            round.player = "paper";
            round.comp = "rock";
            //act
            int damageTaken = Roshambo.DetermineDamage(round.player, round.comp);
            //assert
            Assert.AreEqual(damageTaken, 0);
        }

        [TestMethod]
        public void DetermineDamage_PaperScissorsLose_FifteenDamageTaken()
        {
            //arrange
            (string player, string comp) round;
            round.player = "paper";
            round.comp = "scissors";
            //act
            int damageTaken = Roshambo.DetermineDamage(round.player, round.comp);
            //assert
            Assert.AreEqual(damageTaken, 15);
        }

        [TestMethod]
        public void DetermineDamage_PaperPaperDraw_ZeroDamageTaken()
        {
            //arrange
            (string player, string comp) round;
            round.player = "paper";
            round.comp = "paper";
            //act
            int damageTaken = Roshambo.DetermineDamage(round.player, round.comp);
            //assert
            Assert.AreEqual(damageTaken, 0);
        }

        [TestMethod]
        public void EndGameCheck_StartingHealthValues_ReturnsTrue()
        {
            (int player, int computer) healthValues = (100, 100);
            Assert.IsTrue(Roshambo.EndGameCheck(ref healthValues));
        }

        [TestMethod]
        public void EndGameCheck_PlayerLoses_PrintsCorrectly()
        {
            (int player, int computer) healthValues = (0, 100);

            ConsoleAssert.Expect(@">>
----YOU LOSE!!!----
Would you like to play again ('y' or 'n')?
<<n", () => Roshambo.EndGameCheck(ref healthValues));
        }

        [TestMethod]
        public void EndGameCheck_ComputerLoses_PrintsCorrectly()
        {
            (int player, int computer) healthValues = (100, 0);

            ConsoleAssert.Expect(@">>
----YOU WIN!!!----
Would you like to play again ('y' or 'n')?
<<n", () => Roshambo.EndGameCheck(ref healthValues));
        }

        [TestMethod]
        public void PlayRound_SelectsPaper_PrintsCorrectly()
        {
            ConsoleAssert.Expect(@">>
Enter 'rock', 'paper', or 'scissors':<<paper", () => Roshambo.PlayRound());

        }

        [TestMethod]
        public void PlayRound_SelectsPaper_ReturnsTupleWithPaperSelected()
        {
            string userInput = "paper\n";
            MemoryStream inputStream = new MemoryStream(Encoding.Default.GetBytes(userInput));
            Console.SetIn(new StreamReader(inputStream));
            (string player, string comp)choice = Roshambo.PlayRound();

            Assert.AreEqual("paper", choice.player);
        }

        [TestMethod]
        public void PlayRound_SelectsRock_ReturnsTupleWithRockSelected()
        {
            string userInput = "rock\n";
            MemoryStream inputStream = new MemoryStream(Encoding.Default.GetBytes(userInput));
            Console.SetIn(new StreamReader(inputStream));
            (string player, string comp) choice = Roshambo.PlayRound();

            Assert.AreEqual("rock", choice.player);
        }

        [TestMethod]
        public void PlayRound_SelectsScissors_ReturnsTupleWithScissorsSelected()
        {
            string userInput = "scissors\n";
            MemoryStream inputStream = new MemoryStream(Encoding.Default.GetBytes(userInput));
            Console.SetIn(new StreamReader(inputStream));
            (string player, string comp) choice = Roshambo.PlayRound();

            Assert.AreEqual("scissors", choice.player);
        }

        [TestMethod]
        public void PromptForContinue_UserSelectsNo_ReturnsFalse()
        {
            string userInput = "n\n";
            MemoryStream inputStream = new MemoryStream(Encoding.Default.GetBytes(userInput));
            Console.SetIn(new StreamReader(inputStream));
            Assert.IsFalse(Roshambo.PromptForContinue("WIN"));
        }

        [TestMethod]
        public void PromptForContinue_UserSelectsYes_ReturnsTrue()
        {
            string userInput = "y\n";
            MemoryStream inputStream = new MemoryStream(Encoding.Default.GetBytes(userInput));
            Console.SetIn(new StreamReader(inputStream));
            Assert.IsTrue(Roshambo.PromptForContinue("WIN"));
        }

        [TestMethod]
        public void GetStartingHealthValues_ReturnsCorrectTuple()
        {
            Assert.AreEqual(Roshambo.GetStartingHealthValues(), (100, 100));
        }
    }
}
