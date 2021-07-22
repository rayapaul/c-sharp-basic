using System;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = Convert.ToInt32(Console.ReadLine());
            var height = Convert.ToInt32(Console.ReadLine());
            if (height >= width)
            {
                Console.WriteLine("The image is in Landscape");
            }
            else {
                Console.WriteLine("The image is in potrait");
            }
            Console.WriteLine("Hello World!");
        }
    }
}
