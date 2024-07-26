using System;
using System.Runtime.InteropServices;

namespace @doWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value for numA: ");
            int numA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value for numB: ");
            int numB = Convert.ToInt32(Console.ReadLine());

            int result = numA * numB;
            int answer;

            do
            {
                Console.Write("Enter the value for " + numA + " x " + numB + " = ");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == result)
                    Console.WriteLine("Well done!");
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("The ansewer is incorrect, please try again!");
                }

            } while (answer != result);
            
            Console.ReadLine();
        }
    }
}