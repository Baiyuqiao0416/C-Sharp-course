using System;

namespace sy2_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, l, s;
            double a2, b2;
            Console.Write("第1条直角边=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("第2条直角边=");
            b = Convert.ToDouble(Console.ReadLine());
            a2 = a * a;
            b2 = b * b;
            c = Math.Sqrt(a2 + b2);
            l = a + b + c;
            s = 0.5 * a * b;
            Console.WriteLine("直角边1\t直角边2\t斜边\t周长\t面积");
            Console.WriteLine("{0:F2}\t{1:F2}\t{2:F2}\t{3:F2}\t{4:F2}", a, b, c, l, s);
            Console.ReadKey();
        }
    }
}
         /* string a1 = a.ToString("#0.00");  //取小数位
            string bs = b.ToString("#0.00");
            string cs = c.ToString("#0.00");
            string ls = l.ToString("#0.00");
            string ss = s.ToString("#0.00");*/