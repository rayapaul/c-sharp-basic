using System;
//Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
namespace exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("enter a number or okt to exit.");
                var number = Console.ReadLine();
                if (number == "ok")
                {
                    break;
                }
                sum = sum + Convert.ToInt32(number);
            }
            Console.WriteLine("The sum is:" + sum);
            Console.WriteLine("Hello World!");
        }
    }
}
