using System;
namespace strConcat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Khao";
            int age = 29;
            // concat dung de ghep chuoi
            Console.WriteLine($"My name is {name} and im {age} year old.");
            string test = string.Concat("My name is ", name, " and im ", age, " year old.");
            Console.WriteLine(test);

            // concat co the dung de ghep mot array cac string.
            string[] names = new String[] { "khao ", name, "Listal " };
            Console.WriteLine(string.Concat(names));
            Console.ReadLine();
        }
    }
}