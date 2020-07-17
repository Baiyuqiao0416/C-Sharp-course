using System;

namespace sy2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入日期，格式为：年/月/日");
            DateTime d;
            d = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("该日期是{0}年的第{1}天", d.Year, d.DayOfYear);
            Console.ReadKey();
        }
    }
}
