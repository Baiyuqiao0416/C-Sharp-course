using System;

namespace sy2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double a, b, c, d, e;
            Console.WriteLine("请输入x的值：");
            x = Convert.ToDouble(Console.ReadLine());
            a = Math.Pow(x, 0.5);
            b = Math.Sin(x);
            c = Math.Log(x);
            d = Math.Pow(x, 5);
            e = Math.Exp(x);
            Console.WriteLine("{0}的平方根={1:F4}", x, a);   
            Console.WriteLine("{0}的正弦值={1:F4}", x, b);
            Console.WriteLine("{0}的自然对数={1:F4}", x, c);
            Console.WriteLine("{0}的5次方={1:F4}", x, d);
            Console.WriteLine("{0}的指数函数值={1:F4}", x, e);
            Console.ReadKey();
        }
    }
}
