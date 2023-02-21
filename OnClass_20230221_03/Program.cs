using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnClass_20230221_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一個數字：");
            int r = int.Parse(Console.ReadLine());
            var list = Enumerable.Range(1, r).OrderByDescending(x => x).ToList();

            foreach (var item in list)
            {
                for(int i = 0; i < list.IndexOf(item) + 1; i++)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
        }
    }
}
