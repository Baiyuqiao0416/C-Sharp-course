using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sy2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("依次输入a、b、c的值（逗号隔开）");
            string[] input = Console.ReadLine().Split(',');
            a = Convert.ToInt32(input[0]);
            b = Convert.ToInt32(input[1]);
            c = Convert.ToInt32(input[2]);
            Console.WriteLine("交换前结果为{0} {1} {2}", a, b, c);
            Console.WriteLine("交换后结果为{0} {1} {2}", c, a, b);
            Console.ReadKey();
        }
    }
}
