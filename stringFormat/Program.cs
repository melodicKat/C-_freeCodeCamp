using System;
using System.Globalization;
namespace @stringFormat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double value = 1000D / 12.43D;
            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0:0.00}", value));

                Console.WriteLine(string.Format("{0:0.0}", value));
                Console.WriteLine(string.Format("{0:0}", value));
            decimal money = 200M;

            Console.WriteLine(money.ToString("C0"));
            Console.WriteLine(money.ToString("C2"));
            Console.WriteLine(money.ToString("C3"));
            Console.WriteLine(money.ToString("C4"));
            Console.WriteLine(money.ToString("C5"));
            Console.WriteLine(money.ToString("C6"));

            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));





            Console.ReadLine();
        }
    }
    
}
