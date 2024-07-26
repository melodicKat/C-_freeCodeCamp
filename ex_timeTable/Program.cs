using System;
using System.Globalization;
namespace @ex_timeTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint choice = 0;
            do
            {
                //Choice table.
                Console.WriteLine();
                Console.WriteLine(">>> choice table <<<");
                Console.WriteLine("1. Choose the time table to print.");
                Console.WriteLine("2. Print all time tables from 1 to 10.");
                Console.WriteLine("0. End the program.");


                //tryParse for choice.
                bool checkTryParse_switch = false;

               
                while (!checkTryParse_switch)
                {
                    // enter the choice.
                    Console.WriteLine();
                    Console.Write("Enter your choice: ");
                    checkTryParse_switch = uint.TryParse(Console.ReadLine(), out choice);
                    if (!checkTryParse_switch)
                    {
                        Console.WriteLine("The input value is invalid! pls reenter value!");
                    }
                }

                switch (choice)
                {
                    // case 0, close the program.
                    case 0:
                        Console.WriteLine();
                        Console.WriteLine(">> End the program! <<");
                        break;

                    // case 1, choose the time table to print.
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine(">> Choose the time table to print <<");

                        
                        bool tryParse = false; 
                        while (!tryParse)
                        {
                            Console.WriteLine();
                            Console.Write("Enter the time table: ");

                            // Check if user enter an invalid format value.
                            tryParse = uint.TryParse(Console.ReadLine(), out uint num);
                            if (!tryParse)
                            {
                                Console.WriteLine("Can't convert value!, pls reenter the value.");
                            }

                            // print the time table.
                            else
                            {
                                for (int i = 1; i <= 10; ++i)
                                {
                                    Console.WriteLine($"{num} * {i} = {num * i}");
                                }
                            }
                        }
                        break;

                    // case 2,  Print all time tables from 1 to 10.
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine(">> Print the time table from 1 to 10 <<");
                        for (int i = 1; i <= 10; ++i)
                        {
                            Console.WriteLine();
                            Console.WriteLine("***>>> time table {0} <<<***", i);
                            for (int z = 1; z <= 10; ++z)
                            {
                                Console.WriteLine("{0} * {1} = {2}", i, z, i * z);
                            }
                        }
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid choice, please reenter");
                        break;
                }
            } while (choice != 0);
          
          
         
            Console.ReadLine();
        }
    }
}