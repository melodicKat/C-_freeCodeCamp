using System;

namespace convertStringToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string intString = "-23";

            int age = Convert.ToInt32(intString);
            Console.WriteLine(age);
            string longString = "-9999999";

            long bigNumber = Convert.ToInt64(longString);
            Console.WriteLine(bigNumber);

            string douString = "5.7777";
            double precision = Convert.ToDouble(douString);
            Console.WriteLine(precision);

            string floatString = "5.00001";
            float positive = Convert.ToSingle(floatString);
            Console.WriteLine(positive);

            string decimalSting = "5000";
            decimal money = Convert.ToDecimal(decimalSting);
            Console.WriteLine(money);


            Console.WriteLine(age++);
            Console.WriteLine(++age);
            Console.WriteLine(age);
            Console.ReadLine();
        }
    }
}