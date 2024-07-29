using System;
using System.Security.Principal;

namespace @array
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int[] arr = new int[3];

            

            for(int i = 0; i < arr.Length; ++i)
            {
                int.TryParse(Console.ReadLine(), out arr[i]);
            }
            for(int i = 0; i < arr.Length; ++i)
            {
                Console.WriteLine(arr[i]);
                System.Threading.Thread.Sleep(100);
            }
            Console.ReadLine();
        }
    }
}