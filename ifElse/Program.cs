using System;
namespace ifElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the fist number: ");
            int numberA = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the second number: ");
            int numberB = Convert.ToInt32(Console.ReadLine());


            int answer = numberA * numberB;

            //
            Console.Write($"Nhap vao ket qua cua phep tinh {numberA} x {numberB} = ");
            int userResult = Convert.ToInt32(Console.ReadLine());


            if(answer == userResult)
            {
                Console.WriteLine("Well done");
            }
            else
            {
                Console.WriteLine("close! but not correct");
            }
            Console.ReadLine();
        
        }
    }
}