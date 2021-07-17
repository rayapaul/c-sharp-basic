using System;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = Convert.ToInt32(Console.ReadLine());
            var number2 = Convert.ToInt32(Console.ReadLine());
            if(number1> number2)
            {
                
                Console.WriteLine("{0}",number1);
            }
            else
            {
                Console.WriteLine("{0}", number2);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
