using System;
using System.Collections.Generic;
namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            numbers.Add(1);
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
