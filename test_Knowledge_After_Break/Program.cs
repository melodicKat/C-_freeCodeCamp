using System;
namespace testKnowldle
{
  internal class Program
    {
        static void Main(string[]args)
        {
            bool maxValue_tryParse = false;
            do
            {
                Console.Write("Enter the max value: ");
                maxValue_tryParse = int.TryParse(Console.ReadLine(), out int num);
                if (!maxValue_tryParse)
                {
                    Console.WriteLine("Invalid value! please reenter.");
                }
                else
                {
                    for (int i = 1; i <= num; ++i)
                    {
                        if (i % 3 == 0 && i % 5 == 0)
                            Console.WriteLine("fizz buzz");
                        else if (i % 3 == 0)
                            Console.WriteLine("fizz");
                        else if (i % 5 == 0)
                            Console.WriteLine("buzz");
                        else
                            Console.WriteLine(i);
                    }
                }

            } while (!maxValue_tryParse);
            Console.ReadLine();
        }
    }
}