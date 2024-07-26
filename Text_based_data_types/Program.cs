using System;

namespace textBasedDataType
{
    internal class Program
    {
        static void Main(String[] args)
        {
            //string use ""
            string name = "Khoa";

            //char use ''
            char letter = 'a';

            //sting can be init with no value in side ""
            string testName = "";
            Console.WriteLine($"Test string init with no value in side: {testName}");

            //char can't be init with no value in side '' but we can use \0 presentation for notthing.
            char testChar = '\0';
            Console.WriteLine($"Test char init with \\0 value inside: {testChar} aaa");
            Console.Write("My name is ");
            Console.WriteLine(name);
            Console.WriteLine($"The last character in my name is: {letter}");
            Console.ReadLine();
        }
    }
}

