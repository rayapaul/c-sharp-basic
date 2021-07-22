using System;
using System.Collections.Generic;
using System.Linq;
namespace excersise10
{
    //Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name");
            var input= Console.ReadLine();
            var name = input.ToList();
             name.Reverse();
            var result = string.Join("", name);
            Console.WriteLine("Reversed name is: " + result);
            Console.WriteLine("Hello World!");
        }
    }
}
