using System;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var sum = 1;
            var num = Convert.ToInt32(Console.ReadLine());
            while( num!=1)
            {
                sum = sum * num;
                num--;
                
            }
            Console.WriteLine("Factorial of a number is :" + sum);
            Console.WriteLine("Hello World!");
        }
    }
}
