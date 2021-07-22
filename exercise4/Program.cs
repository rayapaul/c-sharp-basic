using System;

namespace exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            for(var i=1; i<=100; i++)
            {
                if(i %3 == 0)
                {
                    count = count + 1;

                }
            }
            Console.WriteLine("The numbers divisible by 3 between 1 and 100 are: " + count);
            Console.WriteLine("Hello World!");
        }
    }
}
