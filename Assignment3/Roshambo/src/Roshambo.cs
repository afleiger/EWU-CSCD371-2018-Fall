using System;

namespace Roshambo
{
    public class Roshambo
    {
        private static string newLine = Environment.NewLine;

        public static void Main(string[] args)
        {

            Console.WriteLine("----Roshambo----");
            (int player, int comp) healthValues = GetStartingHealthValues();

            do
            {
                Console.WriteLine($"Player HP: {healthValues.player}        Computer HP: {healthValues.comp}");

                (string player, string computer) choice = PlayRound();

                Console.WriteLine($"{newLine}You picked: {choice.player}{newLine}Computer picked: {choice.computer}");

                if (choice.player == choice.computer)
                {
                    Console.WriteLine("-------------------------------------------->Draw");
                }
                else
                {
                    healthValues.player -= DetermineDamage(choice.player, choice.computer);
                    healthValues.comp -= DetermineDamage(choice.computer, choice.player);
                }

            } while (EndGameCheck( ref healthValues));


            Console.WriteLine("Thanks for playing!");
        }

        public static bool EndGameCheck( ref (int player, int computer) healthValues)
        {
            if(healthValues.player < 1)
            {
                healthValues = GetStartingHealthValues();
                return PromptForContinue("LOSE");
            }

            if(healthValues.computer < 1)
            {
                healthValues = GetStartingHealthValues();
                return PromptForContinue("WIN");
            }

            return true;

        }

        public static (int playerHealth, int compHealth) GetStartingHealthValues()
        {
            return (100, 100);
        }

        public static (string player, string computer) PlayRound()
        {
            Console.Write($"{newLine}Enter 'rock', 'paper', or 'scissors':");
            string player = Console.ReadLine().ToLower().Trim();
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