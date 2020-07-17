using System;

namespace sy2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int a, b, c;
            Console.WriteLine("请输入一个三位整数：");
            x = Convert.ToInt32(Console.ReadLine());
            a = x / 100;
            b = (x - a * 100) / 10;
            c = (x - a * 100 - b * 10);
            y = c * 100 + b * 10 + a;
            Console.WriteLine("{0}的反序数是{1}", x, y);
            Console.ReadKey();
        }
    }
}
