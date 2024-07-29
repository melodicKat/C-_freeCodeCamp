using System;
using System.Linq;

namespace strReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Con meo con dang yeu!";

            for(int i = name.Length - 1; i >= 0; --i)
            {
                Console.Write(name[i]);
                System.Threading.Thread.Sleep(100);
            }
            Console.ReadLine();
        }
    }
}