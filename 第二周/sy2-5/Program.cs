using System;

namespace sy2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int a, b, c, d;
            Console.WriteLine("请输入一个四位整数：");
            x = Convert.ToInt32(Console.ReadLine());
            a = x / 1000;
            b = (x - a * 1000) / 100;
            c = (x - a * 1000 - b * 100) / 10;
            d = x - a * 1000 - b * 100 - c * 10;
            Console.WriteLine("个位：{0}", d);
            Console.WriteLine("十位：{0}", c);
            Console.WriteLine("百位：{0}", b);
            Console.WriteLine("千位：{0}", a);
            Console.ReadKey();
        }
    }
}
