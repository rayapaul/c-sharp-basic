using System;

namespace CsharpClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           var raya = new Person();
            raya.FirstName = "Raya";
            raya.LastName = "Paul";
            raya.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
