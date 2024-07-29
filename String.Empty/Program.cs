using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace String.Empty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            // string name = ""; bằng với  string name = string.Empty; 
            // cả hai đều là khai báo và khởi tạo một string rỗng;
            // tuy vậy để tránh xảy ra lỗi thì ta nên sử dụng string.Empty, nếu sử dụng "" có khả năng thêm thừa khoảng trống "  " gây ra lỗi.

            string name2 = string.Empty;

            name2 = Console.ReadLine();
            if(name2 == string.Empty)
                Console.WriteLine("Pls enter your name!");
            
           int check =  name.CompareTo(name2);
            Console.WriteLine(check);
            Console.ReadLine();
        }
    }
}