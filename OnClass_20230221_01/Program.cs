using System;
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
            var count = list.Count;
            var list2 = new List<string>();

            for(int i = 0; i < count; i++)
            {
                list2.Add(list.Skip(count - i - 1).Take(1).First());
            }
            
            int n = 0;
            foreach(var item in list2)
            {
                Console.Write(item);
                n++;
                if(n < count)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
