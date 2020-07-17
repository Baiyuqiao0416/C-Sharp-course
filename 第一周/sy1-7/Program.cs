using System;

namespace sy1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            char a, i, c;
            i = Convert.ToChar(Console.ReadLine());
            a = Convert.ToChar(i - 1);
            c = Convert.ToChar(i + 1);
            Console.WriteLine("{0} {1} {2}", a, i, c);
            Console.ReadKey();
        }
    }
}
