using System;

namespace iselse
{
    public enum Season
    {
        Spring,
        Autumn,
        Summer,
        Winter,
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int hour = 10;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("Its Morning");

            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Its afternoon");
            }
            else
            {
                Console.WriteLine("Its night");
            }
            //switch case
            var season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("Its autumn and beautiful time");
                    break;
                case Season.Summer:
                    Console.WriteLine("Its summer and beautiful time");
                    break;
                default:
                    Console.WriteLine("i dont understand that season");
                    break;
            }
        }
        
    }
}
