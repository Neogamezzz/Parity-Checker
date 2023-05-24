using System;

namespace Parity_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to check its parity.");

            while (true)
            {
                Console.Write("Your number: ");
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Invalid value. Try again.");
                    continue;
                }
                int remainder = number % 2;
                
                if (remainder == 0)
                {
                    Console.WriteLine("This number is even");
                }
                else
                {
                    Console.WriteLine("This number is odd");
                }
            }
        }
    }
}
