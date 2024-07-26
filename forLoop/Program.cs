using System;
using System.Runtime.InteropServices;

namespace @forLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many times do you want say \"fuck this shit\"? ");
            int number = Convert.ToInt32(Console.ReadLine());
        


            if(number <= 0)
            {
                Console.WriteLine("Please! enter value above 0.");
            }
            else
            for (int i = 0; i < number; ++i)
            {
                Console.WriteLine("Fuck this shit!");
            }    

            //for (int i = 1; i < 10; i += 2)
            //{
            //    Console.WriteLine(i);
            //}    
            Console.ReadLine();
        }
    }
}