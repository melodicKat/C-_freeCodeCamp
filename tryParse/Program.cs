using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace @tryParse
{
    internal class program
    {
        static void Main(string[]args)
        {
            bool tryParse = false;

            while(!tryParse)
            {
                Console.Write("Enter the value: ");
                tryParse = decimal.TryParse(Console.ReadLine(), out decimal num);

                if(tryParse)
                {
                    Console.WriteLine("Converted!");
                }
                else
                    Console.WriteLine("Failed to convert!");
                Console.WriteLine(num);

            }
            Console.ReadLine();
        }
    }
}