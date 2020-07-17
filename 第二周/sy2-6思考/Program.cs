using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sy2_6思考
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int min, max;
            Console.WriteLine("请输入三个整数：");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            min = Math.Min(a, b);
            min = Math.Min(min, c);
            max = Math.Max(a, b);
            max = Math.Max(max, c);
            Console.WriteLine("最大：{0} 最小：{1}", max, min);
            Console.ReadKey();
        }
    }
}
