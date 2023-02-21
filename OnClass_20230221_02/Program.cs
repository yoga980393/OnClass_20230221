using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnClass_20230221_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入帶,的字串");
            var list = Console.ReadLine().Split(',');
            var list2 = list.Where(x => int.Parse(x) % 2 == 0).OrderBy(x => x);
            var list3 = list.Where(x => int.Parse(x) % 2 == 1).OrderBy(x => x);

            Console.Write("偶數有：");
            int n = 0;
            foreach(var item in list2)
            {
                Console.Write(item);
                if(n < list2.Count() - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.Write("\n奇數有：");
            int m = 0;
            foreach (var item in list3)
            {
                Console.Write(item);
                if (m < list2.Count() - 1)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
