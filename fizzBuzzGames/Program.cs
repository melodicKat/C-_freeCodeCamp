using System;
using System.Runtime.Remoting.Services;

namespace @fizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool input_tryparse = false;
            do
            {
                Console.Write("Enter the max range value: ");
                input_tryparse = int.TryParse(Console.ReadLine(), out int input);
                if (!input_tryparse)
                {
                    Console.WriteLine();
                    Console.WriteLine("invalid value, please reenter!");

                }
                else
                {
                    Console.WriteLine(">>> The result <<<");
                    for (int i = 1; i <= input; ++i)
                    {
                        if (i % 5 == 0 && i % 3 == 0)
                            Console.WriteLine("Fizz Buzz");
                        else if (i % 3 == 0)
                            Console.WriteLine("Fizz");
                        else if (i % 5 == 0)
                            Console.WriteLine("Buzz");
                        
                        else
                            Console.WriteLine(i);
                    }
                }
            } while (!input_tryparse);
            Console.ReadLine();
        }
    }
}