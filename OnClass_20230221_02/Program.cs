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

            Console.Write($"偶數有：{string.Join(",", list2)}");
            Console.Write($"奇數有：{string.Join(",", list3)}");
        }
    }
}
