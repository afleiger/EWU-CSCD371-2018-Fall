using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Roshambo.Tests
{
    [TestClass]
    public class RoshamboUnitTest
    {
        [TestMethod]
        public void RandomChoice_ReturnsValidManyTimes()
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
        public void DetermineDamage_Win_ZeroDamageTaken()
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
        public void DetermineDamage_LoseToRock_DamageTaken()
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
        public void DetermineDamage_Draw_ZeroDamageTaken()
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
    }
}
