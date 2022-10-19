using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //有一個數值,是四位數
            //左邊二位的數字相同
            //右邊二位的數字相同
            //這個四位數值, 剛好也是某整數的平方
            //請問這個四位數值是什麼?

            int number1=1000;
            int number2 = 10000;
			double d1 = Math.Sqrt(number1);
			int value1 = (int)Math.Ceiling(d1);

			double d2= Math.Sqrt(number2);
			int value2 = (int)Math.Floor(d2);
			

			for (int i = value1; i < value2; i++)
            {
                if(Math.Pow(i, 2)>999 || Math.Pow(i, 2) < 10000)
                {
                    double resulet1=Math.Pow(i, 2);
                    string value3 = resulet1.ToString();
                    
					if (value3[0]== value3[1]&& value3[2] == value3[3])
                    {
                        Console.WriteLine($"答案為:{value3}");
                    }
                }
            }
		}
    }
}
