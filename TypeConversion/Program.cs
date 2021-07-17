using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b;
            Console.WriteLine(i);
            int a = 7;
            byte c = (byte)a;
            Console.WriteLine(c);
            var number = "12345";
            int z = Convert.ToInt32(number);
            Console.WriteLine(z);
            try
            {
                var num = "12456";
                byte y = Convert.ToByte(num);
                Console.WriteLine(y);
            }
            catch (Exception)
            {
                Console.WriteLine("the number could not be coverted to a byte");
               
            }
           
        }
    }
}
