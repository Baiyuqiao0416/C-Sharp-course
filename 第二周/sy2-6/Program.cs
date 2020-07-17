using System;

namespace sy2_6
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
            min = a < b ? a : b;
            min = min < c ? min : c;
            max = a > b ? a : b;
            max = max > c ? max : c;
            Console.WriteLine("最大：{0} 最小：{1}", max, min);
            Console.ReadKey();
        }
    }
}
