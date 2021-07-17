using System;

namespace whileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            //while loop is done when we dont know the number of iterations required 
            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                    i++;
                
            }

            Console.WriteLine("Hello World!");
        }
    }
}
