using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //百元買百雞
            //想用一百元買剛好一百隻雞, 公雞 5 元, 母雞 3 元, 小雞三隻 1 元
            //字彙表:
            //公雞(Cock), 母雞(Hen), 小雞(Chicken)
            //15x+9y+z=300
            //x+y+z=100

            for (int i = 0; i <= 20; i++)
            {
                for (int k = 0; k <=33; k++)
                {
                  if(i*5+k*3+(double)(100-i-k)/3 ==100 )
                  {
                        Console.WriteLine($"公雞數量為{i} 母雞數量為{k}小雞數量為{100-i-k}");
                  }
                }
            }

        }
    }
}
