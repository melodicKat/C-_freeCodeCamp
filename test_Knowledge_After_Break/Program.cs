using System;
using System.Runtime.InteropServices;

namespace testKn
{
    class Program
    { 
        // module for byte input
        static byte numIntPut()
        {
            byte num;
            bool checkChoice = false;
            do
            {
                Console.Write("Enter the value: ");
                checkChoice = byte.TryParse(Console.ReadLine(), out num);
                if (!checkChoice)
                {
                    Console.WriteLine();
                    Console.WriteLine("Your input is not availble, please reenter!");
                }
            } while (!checkChoice);
            return num;
        }

        //print time table for separate number.
        static void timeTable_separate(byte num)
        {
            for (int i = 0; i < 11; ++i)
            {
                Console.WriteLine("{0} * {1} = {2}", num, i, num * i);
            }
        }

        //print the time table from 1 - 10
        static void timeTable_1_10()
        {
            for (byte i = 1; i < 11; ++i)
            {
                Console.WriteLine("Time table {0}: ", i);
                timeTable_separate(i);
            }
        }
        static void Choice(byte choice)
        {

            do
            {
                Console.Write("Your choice | ");
                choice = numIntPut();
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("End the program!");
                        break;
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Print the time table.");
                        byte timeTableIndex = numIntPut();
                        timeTable_separate(timeTableIndex);
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Print the time table from 1 to 10.");
                        timeTable_1_10();
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Passwork checker.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            }
            while (choice != 0);

        }

        static void Main(string[] args)
        {
            byte choice = 0;
            Choice(choice);

            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}

