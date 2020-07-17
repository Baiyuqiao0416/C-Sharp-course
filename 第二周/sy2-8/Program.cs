using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sy2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("依次输入a和b的值（一个空格隔开）");
            string[] input = Console.ReadLine().Split(' ');
            a = Convert.ToInt32(input[0]);
            b = Convert.ToInt32(input[1]);
            Console.WriteLine("交换前结果为：{0} {1}", a, b);
            Console.WriteLine("交换后结果为：{0} {1}", b, a);
            Console.ReadKey();
        }
    }
}
