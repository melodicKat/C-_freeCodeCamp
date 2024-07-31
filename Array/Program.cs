using System;
namespace @arr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[count];
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write("arr{0} = ", i + 1);
                int.TryParse(Console.ReadLine(), out arr[i]);
            }
            int sum = 0;
            foreach(int arrIndex in arr)
            {
                sum += arrIndex;
            }

            Console.WriteLine(sum + (sum < 120 ? "valid" : "invalid"));
            Console.ReadLine();
        }
    }
}