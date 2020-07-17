using System;

namespace sy1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, t;
            Console.Write("a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c=");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("交换前：a={0} b={1} c={2}", a, b, c);
            t = a;
            a = b;
            b = t;  //交换ab
            t = a;
            a = c;
            c = t;  //交换ac
            Console.WriteLine("交换后：a={0} b={1} c={2}", a, b, c);
            Console.ReadKey();
        }
    }
}
