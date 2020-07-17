using System;

namespace sy1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}+{1}+{2}={3}", a, b, c, a + b + c);
            Console.WriteLine("{0}*{1}*{2}={3}", a, b, c, a * b * c);
            Console.ReadKey();
        }
    }
}
