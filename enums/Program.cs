using System;

namespace enums
{
    public enum ShippingMethod
    {
        RegularAirMail=1,
        RegisteredAirMail=2,
        Express=3,

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);
        }
    }
}
