using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number=2;
            int count = 10;
            float totalPrice = 20.86f;
            char character = 'A';
            string firstName = "Raya";
            bool isWorking = false;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine(character);
            Console.WriteLine("{0},{1}", byte.MinValue, byte.MaxValue);
        }
    }
}
