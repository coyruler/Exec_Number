using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //找出數值區間內的所有質數

            Console.WriteLine("請輸入第一個正整數");
            string value = Console.ReadLine();
            int n = Convert.ToInt32(value);

            Console.WriteLine("請輸入第二個正整數");
            string value2 = Console.ReadLine();
            int n2 = Convert.ToInt32(value2);
            //n1 n2 排大小往大找
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
