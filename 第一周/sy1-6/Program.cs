using System;

namespace sy1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int time, h, m;
            time = Convert.ToInt32(Console.ReadLine());
            h = time / 60;
            m = time % 60;
            Console.WriteLine("{0}小时{1}分钟", h, m);
            Console.ReadKey();
        }
    }
}
