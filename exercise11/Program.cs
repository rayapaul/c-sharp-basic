using System;
using System.Collections.Generic;
namespace exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter Unique numbers");
                var number= Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("Provide a number that hasn't been used before");
                }
                else
                {
                    numbers.Add(number);
                }

                if (numbers.Count == 5)
                    { 
                    numbers.Sort();
                    break;
                }

                foreach (var i in numbers)
                {
                    Console.WriteLine(i);
                }
            }
            

            Console.WriteLine("Hello World!");
        }
    }
}
