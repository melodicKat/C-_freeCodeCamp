using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace arrayMedthod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Enter the count of array
            Console.Write("Enter the number of array element: ");
            int.TryParse(Console.ReadLine(), out int count);
            int[] arr = new int[]
            {
                1,1,2,3,4,5,6,7
            };


            //xap xep arr theo thu tu tang dan
            Array.Sort(arr);

            foreach(int num in arr)
            {
                Console.WriteLine(num);
            }

            //reverse arr
            Array.Reverse(arr);
            foreach (int num in arr)
            {
                Console.Write(num);
            }
            Console.WriteLine();

            //index of
            //tim kiem phan tu co trong mang va tra ve index neu co, khong thi tra ve -1
            int position = Array.IndexOf(arr, 6);
            Console.WriteLine(position);
            //clear arr "thuc chat la gan tat cả gia tri cua arr thanh 0.
            Array.Clear(arr, 5, 2);// arr, vi tri bat dau xoa, do dai muon xoa tinh tu vi tri bat dau xoa.

            foreach(int num in arr)
            {
                Console.Write(num);
            }
            Console.WriteLine();

            //co the dung vong lap for de thuc hien clear, ve ban chat lenh clear chi la lenh reset cac gia tri cua mang ve gia tri default.
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = default;
            }
            foreach (int num in arr)
            {
                Console.Write(num);
            }
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}