using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACSII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char test;
            for (int i = 0; i < 256; ++i)
            {
                test = (char)i;
                Console.WriteLine(test + " - " + i);
                System.Threading.Thread.Sleep(100);
            }
            Console.ReadLine();
        }
    }
}
