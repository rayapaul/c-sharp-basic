using System;
using System.IO;
namespace files
{
    class Program
    {
        static void Main(string[] args)
        {
            //Directory.CreateDirectory(@"c:\Users\RAYA");
           var files= Directory.GetFiles(@"c:\Users\RAYA","*.config*",SearchOption.AllDirectories);
            foreach(var file in files)
            {
                Console.WriteLine(file);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
