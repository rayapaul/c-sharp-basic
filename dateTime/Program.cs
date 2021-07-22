using System;

namespace dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //dateTime type using new operator,immutable->once created cannot be changed but modified
            var dateTime = new DateTime(2015,1,2);
            Console.WriteLine(dateTime);
            var now = DateTime.Now;
            Console.WriteLine(now);
            var today = DateTime.Today;
            Console.WriteLine(today);
            var tomorrow = now.AddDays(1);
            Console.WriteLine(tomorrow);
            var yesterday = now.AddDays(-1);
            Console.WriteLine(yesterday);
            Console.WriteLine("Hello World!");
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-mm-dddd HH-mm"));
            //Creating timeSpan object, immutable->once created cannot be changed but modified
            var timeSpan = new TimeSpan(1, 2, 3);
            Console.WriteLine(timeSpan);
            var timeSpan2 = new TimeSpan(1, 2, 3, 4, 5);
            Console.WriteLine(timeSpan2);
            Console.WriteLine("tostring :" +timeSpan.ToString());
            Console.WriteLine("to parse:" + TimeSpan.Parse("1:02:04"));
        }
    }
}
