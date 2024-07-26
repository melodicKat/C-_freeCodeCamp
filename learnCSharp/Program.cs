using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace learnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = - 23;
            long conmeo = -100000000l;
            double doubleNum = -102.2d;
            float floatNum = 10.000001f;
            decimal decimalNum = 50.4m;

            Console.WriteLine(conmeo);
            Console.WriteLine(age);
            Console.WriteLine($"int max value: {int.MaxValue}");
            Console.WriteLine($"int min value: {int.MinValue}");


            Console.WriteLine($"Long max value: {long.MaxValue}");
            Console.WriteLine($"Long min value: {long.MinValue}");


            Console.WriteLine(doubleNum);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);


            Console.ReadLine();
        }
    }
}
