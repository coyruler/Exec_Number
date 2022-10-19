using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //判斷某數值是不是質數

            Console.WriteLine("請輸入一個正整數");
            string value = Console.ReadLine();
            int n = Convert.ToInt32(value);
            int root = (int)Math.Ceiling(Math.Sqrt(n)); 

            for (int i = 2; i < root; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("不是質數!!");
                    Console.WriteLine("因為它可以被" + i + "整除");
                    // break;
                    return;
                }
            }

            Console.WriteLine("它是質數");

        }
    }
}
