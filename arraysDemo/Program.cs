using System;

namespace arraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 4, 6, 7 };
            //length
            Console.WriteLine("Length" + numbers.Length);
            //IndexOf
            var index = Array.IndexOf(numbers, 6);
            Console.WriteLine("index of 6 is: {0}", index);
            //Clear
            Array.Clear(numbers, 0, 2);
            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
