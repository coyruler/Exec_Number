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

            Console.WriteLine("請輸入二個正整數，並用 , 分開");
            string value = Console.ReadLine();
			int[] numbers = value.Split(',').Select(int.Parse).ToArray();

			if (numbers.Length ==2 && (numbers[0] != numbers[1])&& numbers[0] >0 && numbers[1] > 0)
            {
                Array.Sort(numbers);
				Console.WriteLine("區間內的所有質數:");
				for (int i = numbers[0]; i <= numbers[1]; i++)
                {
                    for (int k = 2; k <= numbers[1]; k++)
                    {
                        if (i % k == 0 && i != k)
                        {
                            break;
                        }

                        if (i % k == 0 && i == k)
                        {
                            Console.WriteLine(i);
                        }
                     }					
                 }				
			}
            else
            {
				Console.WriteLine("只能輸入二個正整數，並用 , 分開");
			}
			
		}
	}
}
