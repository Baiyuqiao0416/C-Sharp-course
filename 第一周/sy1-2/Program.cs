using System;

namespace sy1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Welcome {0}", name);
            Console.WriteLine("Goodbye {0}", name);
            Console.ReadKey();
        }
    }
}
