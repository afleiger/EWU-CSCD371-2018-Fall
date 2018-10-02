using System;

namespace SimpleMathSolver
{
    class SimpleMathSolver
    {
        static void Main(string[] args)
        {
            double[] nums = null;
            bool IsQuitting = false;
            String output = "Formatting Error -- Please submit in {Value}{Operator}{Value} form.";

            Console.WriteLine("----Math Solver----");

            while (IsQuitting != true)
            {
                Console.WriteLine(Environment.NewLine + "Enter a problem ('Q' to quit): ");
                String input = Console.ReadLine();
                if (input.Trim().ToLower().Equals("q"))
                {
                    IsQuitting = true;
                }

                else if (input.Contains("+"))
                {
                    nums = ParseNumbers(input.Split("+"));
                    if (nums != null)
                    {
                        output = (nums[0] + nums[1]).ToString();
                    }
                }

                else if (input.Contains("-"))
                {
                    nums = ParseNumbers(input.Split("-"));
                    if (nums != null)
                    {
                        output = (nums[0] - nums[1]).ToString();
                    }
                }

                else if (input.Contains("*"))
                {
                    nums = ParseNumbers(input.Split("*"));
                    if (nums != null)
                    {
                        output = (nums[0] * nums[1]).ToString();
                    }
                }

                else if (input.Contains("/"))
                {
                    nums = ParseNumbers(input.Split("/"));
                    if (nums != null)
                    {
                        if(nums[1] != 0)
                        {
                            output = (nums[0] / nums[1]).ToString();
                        }
                        else
                        {
                            output = "Error -- Divide by zero.";
                        }
                    }
                }

                Console.WriteLine($"Answer: {output}");
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
    }
}
