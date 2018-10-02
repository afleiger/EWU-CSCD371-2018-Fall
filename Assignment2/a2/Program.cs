using System;
using System.Numerics;

namespace SimpleMath
{
    class SimpleMath
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            if (input.Contains("+"))
            {
                String[] nums = input.Split("+");

                BigInteger num1, num2;
                if (BigInteger.TryParse(nums[0], out num1))
                {
                    if(BigInteger.TryParse(nums[1], out num2))
                    {
                        Console.WriteLine(num1 + num2);
                    }
                }
            }
            Console.ReadLine();

        }
    }
}
