using System;

namespace SimpleMathSolver
{
    class SimpleMathSolver
    {
        static string formatErrorMsg = "Formatting Error -- Please submit in {Value}{Operator}{Value} form.";

        static void Main(string[] args)
        {
            double[] nums = null;
            bool IsQuitting = false;
            string outputString = formatErrorMsg;

            Console.WriteLine("----Math Solver----");

            while (IsQuitting != true)
            {
                outputString = formatErrorMsg;
                Console.WriteLine(Environment.NewLine + "Enter a problem ('Q' to quit): ");
                String input = Console.ReadLine();
                if (input.Trim().ToLower().Equals("q"))
                {
                    IsQuitting = true;
                }

                else if (input.Contains("+"))
                {
                    outputString = Addition(input);
                }

                else if (input.Contains("-"))
                {
                    outputString = Subtraction(input);
                }

                else if (input.Contains("*"))
                {
                    outputString = Multiplication(input);
                }

                else if (input.Contains("/"))
                {
                    outputString = Division(input);
                }

                Console.WriteLine($"Output: {outputString}");
            }


        }

        static double[] ParseNumbers(String[] stringArray)
        {
            double[] doubleArray = new double[2];
            if (double.TryParse(stringArray[0].Trim(), out doubleArray[0]) && double.TryParse(stringArray[1].Trim(), out doubleArray[1]))
            {
                return doubleArray;
            }
            else return null;
        }

        static String Addition(String userInput)
        {
            String output = formatErrorMsg;

            double[] nums = ParseNumbers(userInput.Split("+"));
            if (nums != null)
            {
                output = (nums[0] + nums[1]).ToString();
            }
            return output;
        }

        static String Subtraction(String userInput)
        {
            String output = formatErrorMsg;

            double[] nums = ParseNumbers(userInput.Split("-"));
            if (nums != null)
            {
                output = (nums[0] - nums[1]).ToString();
            }
            return output;
        }

        static String Multiplication(String userInput)
        {
            String output = formatErrorMsg;

            double[] nums = ParseNumbers(userInput.Split("*"));
            if (nums != null)
            {
                output = (nums[0] * nums[1]).ToString();
            }
            return output;
        }

        static String Division(String userInput)
        {
            String output = formatErrorMsg;

            double[] nums = ParseNumbers(userInput.Split("/"));
            if (nums != null)
            {
                if (nums[1] != 0)
                {
                    output = (nums[0] / nums[1]).ToString();
                }
                else
                {
                    output = "Error -- Divide by zero.";
                }
            }
            return output;
        }
    }
}
