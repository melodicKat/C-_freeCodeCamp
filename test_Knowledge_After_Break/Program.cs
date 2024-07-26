using System;
using System.Globalization;

namespace @test_Knowledge_After_Break
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int choice = 0;
            do
            {
                Console.WriteLine();
                Console.WriteLine(">> Table of choice <<");
                Console.WriteLine("1. Choose the time table to print.");
                Console.WriteLine("2. Print the time table from 1 to 10");
                Console.WriteLine("0. End the program");

                bool choice_tryparse = false;
                while (!choice_tryparse)
                {
                    Console.WriteLine();
                    Console.Write("Enter your choice: ");
                    choice_tryparse = int.TryParse(Console.ReadLine(), out choice);
                    if(!choice_tryparse)
                    {
                        Console.WriteLine("Failed to convert! please reenter the value");
                    }
                }

                switch(choice)
                {
                    case 0:
                        Console.WriteLine();
                        Console.WriteLine(">> end the program <<");
                        break;
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine(">>> Choose the time table to print <<<");
                        Console.WriteLine();
                        

                        bool case1_tryparse = false;
                        while(!case1_tryparse)
                        {
                            Console.Write("Enter the time table to print: ");
                            case1_tryparse = int.TryParse(Console.ReadLine(), out int num);
                            if (!case1_tryparse)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Invalid input! pls reenter");
                            }
                            else
                                for (int i = 1; i < 11; ++i)
                                    Console.WriteLine($"{num} * {i} = {num * i}");
                            
                        }
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine(">>> Print time tables from 1 - 10 <<<");
                        Console.WriteLine();
                        for(int i = 0; i < 11; ++i )
                        {
                            Console.WriteLine();
                            Console.WriteLine("Time table {0}", i);
                            for (int z = 0; z < 11; ++z)
                            {
                                Console.WriteLine("{0} * {1} = {2}", i, z, i*z);
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("invalid choice, pls reenter");

                        break;

                }

            } while (choice != 0);
                
            Console.ReadLine();
        }
    }
}