using System;

namespace sy1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, t;
            Console.Write("a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("交换前：a={0} b={1}", a, b);
            t = a;
            a = b;
            b = t;
            Console.WriteLine("交换后：a={0} b={1}", a, b);
            Console.ReadKey();
        }
    }
}
