using System;

namespace sy1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2, a;
            double s;
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            a = (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);
            s = Math.Sqrt(a);
            Console.WriteLine("点({0},{1})与({2},{3})之间的距离为：{4}", x1, y1, x2, y2, s);
            Console.ReadKey();
        }
    }
}
