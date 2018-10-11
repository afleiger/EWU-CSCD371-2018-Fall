using System;

namespace Roshambo
{
    public class Roshambo
    {
        public static string newLine = Environment.NewLine;

        public static void Main(string[] args)
        {

            Console.WriteLine("----Roshambo----");
            while (PlayGame());
            Console.WriteLine("Thanks for playing!");
        }

        public static bool PlayGame()
        {
            int playerHealth = 100, compHealth = 100;

            do
            {
                Console.WriteLine($"Player HP: {playerHealth}        Computer HP: {compHealth}");

                Console.Write($"{newLine}Enter 'rock', 'paper', or 'scissors':");
                (string player, string computer) round = PlayRound(Console.ReadLine().ToLower().Trim());

                Console.WriteLine($"{newLine}You picked: {round.player}{newLine}Computer picked: {round.computer}");

                if (round.player == round.computer)
                {
                    Console.WriteLine("-------------------------------------------->Draw");
                }
                else
                {
                    playerHealth -= DetermineDamage(round.player, round.computer);
                    compHealth -= DetermineDamage(round.computer, round.player);
                }
            } while (playerHealth > 0 && compHealth > 0);

            if (playerHealth < 1)
                return PromptForContinue("LOSE");

            return PromptForContinue("WIN");

        }

        public static (string player, string computer) PlayRound(string player)
        {
            string computer = RandomChoice();
            return (player, computer);
        }

        public static string RandomChoice()
        {
            Random rand = new Random();
            string ret = "rock";
            switch (rand.Next(1, 4))
            {
                case 1:
                    ret = "paper";
                    break;
                case 2:
                    ret = "scissors";
                    break;
            }
            return ret;
        }

        public static int DetermineDamage(string player, string opponent)
        {
            switch (player)
            {
                case "rock":
                    if (opponent == "paper")
                    {
                        Console.WriteLine("-------------------------------------------->Paper covers Rock");
                        return 10;
                    }
                    break;
                case "paper":
                    if (opponent == "scissors")
                    {
                        Console.WriteLine("-------------------------------------------->Scissors cuts Paper");
                        return 15;
                    }
                    break;
                case "scissors":
                    if (opponent == "rock")
                    {
                        Console.WriteLine("-------------------------------------------->Rock crushes Scissors");
                        return 20;
                    }
                    break;
            }
            return 0;
        }

        public static bool PromptForContinue(string outcome)
        {
            Console.WriteLine($"{newLine}----YOU {outcome}!!!----{newLine}Would you like to play again ('y' or 'n')?");
            if (Console.ReadLine().ToLower().Trim() == "y")
                return true;
            return false;
        }
    }
}