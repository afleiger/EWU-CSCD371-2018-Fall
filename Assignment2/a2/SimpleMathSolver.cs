using System;

namespace SimpleMathSolver
{
    public class SimpleMathSolver
    {
        static string formatErrorMsg = "Formatting Error -- Please submit in {Value}{Operator}{Value} form.";

        public static void Main(string[] args)
        {
            string outputString = formatErrorMsg;

            outputString = formatErrorMsg;
            Console.WriteLine("Enter a problem: ");
            String input = Console.ReadLine();

            if (input.Contains("+"))
            {
                outputString = Addition(input);
            }
            else if (input.Contains("*"))
            {
                outputString = Multiplication(input);
            }

            else if (input.Contains("/"))
            {
                outputString = Division(input);
            }
            else if (input.Contains("^"))
            {
                outputString = Exponent(input);
            }
            else if (input.Contains("%"))
            {
                outputString = Modulus(input);
            }
            else if (input.Contains("-"))
            {
                outputString = Subtraction(input);
            }

            Console.WriteLine($"Output: {outputString}");
        }

        static double[] ParseNumbers(String[] stringArray)
        {
            String firstNumber = "", secondNumber = "";
            foreach (char c in stringArray[0])
            {
                if (c == '!' || c == '@')
                {
                    firstNumber += '-';
                }
                else
                {
                    firstNumber += c;
                }
            }
            foreach (char c in stringArray[1])
            {
                if (c == '!' || c == '@')
                {
                    secondNumber += '-';
                }
                else
                {
                    secondNumber += c;
                }
            }
            double[] doubleArray = new double[2];
            if (double.TryParse(firstNumber.Trim(), out doubleArray[0]) && double.TryParse(secondNumber.Trim(), out doubleArray[1]))
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

        static String Exponent(String userInput)
        {
            String output = formatErrorMsg;

            double[] nums = ParseNumbers(userInput.Split("^"));
            if (nums != null)
            {
                output = Math.Pow(nums[0], nums[1]).ToString();
            }
            return output;
        }

        static String Modulus(String userInput)
        {
            String output = formatErrorMsg;

            double[] nums = ParseNumbers(userInput.Split("%"));
            if (nums != null)
            {
                output = (nums[0] % nums[1]).ToString();
            }
            return output;
        }

        static String Subtraction(String userInput)
        {
            String output = formatErrorMsg;
            int minusCount = 1;

            String trimInput = userInput.Trim();
            if (trimInput.Contains("!") || trimInput.Contains("@"))
            {
                return output;
            }

            String convertedString = "";
            foreach (char c in trimInput)
            {
                if (c == '-' && convertedString.Contains("-"))
                {
                    if (!convertedString.Contains("!"))
                    {
                        convertedString += "!";
                        minusCount = 2;
                    }
                    else
                    {
                        convertedString += "@";
                        minusCount = 3;
                    }
                }
                else
                {
                    convertedString += c;
                }
            }

            double[] nums = null;
            switch (minusCount)
            {
                case 1:
                    nums = ParseNumbers(convertedString.Split("-"));
                    break;
                case 2:
                    nums = ParseNumbers(convertedString.Split("-"));
                    if (nums == null)
                    {
                        nums = ParseNumbers(convertedString.Split("!"));
                    }
                    break;
                case 3:
                    nums = ParseNumbers(convertedString.Split("!"));
                    break;
            }

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
