using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnClass_20230221_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入帶,的字串");
            var list = Console.ReadLine().Split(',').ToList();
            var list2 = list.OrderByDescending(x => list.IndexOf(x));
            Console.WriteLine(string.Join(",", list2));
        }
    }
}
