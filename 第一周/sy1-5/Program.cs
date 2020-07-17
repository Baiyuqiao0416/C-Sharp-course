using System;

namespace sy1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;
            int b;
            a = Convert.ToChar(Console.ReadLine());
            b = Convert.ToInt32(a);
            Console.WriteLine("{0}的ASCII码是{1}", a, b);
            Console.ReadKey();
        }
    }
}
