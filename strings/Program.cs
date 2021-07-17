using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var firstName = "raya";
             var lastName = "paul";
            var fullName = firstName + "" + lastName;
            Console.WriteLine(fullName);
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(myFullName);
        }
    }
}
