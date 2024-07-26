using System;
namespace @whileLoop
{
    internal class Program
    {
        static void Main(string[]args)
        {
            Console.Write("Enter number A: ");
            int numberA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number B: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            int result = numberA * numberB;

            Console.Write($"Enter the answer for {numberA} x {numberB} = ");
            int answer = Convert.ToInt32(Console.ReadLine());

            while(answer != result)
            {
                Console.WriteLine();
                Console.WriteLine("Close! but the answer was wrong. Please try again");
                Console.Write($"Reenter the answer for {numberA} x {numberB} = ");
                answer = Convert.ToInt32(Console.ReadLine());
               
            }
            Console.WriteLine("Well done!");


            Console.ReadLine();
        }
    }
}