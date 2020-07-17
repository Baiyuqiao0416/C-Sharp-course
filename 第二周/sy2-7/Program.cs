using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sy2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("两个数学常量（左对齐）：");
            Console.WriteLine("{0,-20}{1,-20}","e","PI");
            Console.WriteLine("{0,-20}{1,-20}", Math.E, Math.PI);
            Console.WriteLine("两个数学常量（右对齐）：");
            Console.WriteLine("{0,20}{1,20}", "e", "PI");
            Console.WriteLine("{0,20}{1,20}", Math.E, Math.PI);
            Console.ReadKey();
        }
    }
}
