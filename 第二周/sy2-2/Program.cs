using System;

namespace sy2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime a = Convert.ToDateTime("2020/7/24");    //奥运会时间
            DateTime c = DateTime.Now.Date;                  //现在时间
            string d = DateTime.Now.ToLongDateString().ToString();  //字符串现在时间
            Console.WriteLine("今天{0}",d);
            TimeSpan ts = a - c;               //时间间隔
            int day = ts.Days;                 //取出day
            Console.WriteLine("离2020年东京奥运会开幕还有{0}天", day);
            Console.ReadKey();
        }
    }
}
