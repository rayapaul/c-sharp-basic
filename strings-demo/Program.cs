using System;
using System.Text;
namespace strings_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Raya Paul ";
            Console.WriteLine("trim: '{0}'", fullName.Trim());
            Console.WriteLine("toupper: '{0}'", fullName.ToUpper());
            Console.WriteLine("to lower: '{0}'", fullName.ToLower());
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index+1);
            Console.WriteLine("first name is:"+ firstName);
            Console.WriteLine("last name is:"+lastName);
            Console.WriteLine("Hello World!");
            var names = fullName.Split(' ');
            Console.WriteLine("firstname:" + names[0]);
            Console.WriteLine("lastname:" + names[1]);
            var builder = new StringBuilder();
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append('-', 10);
            Console.WriteLine(builder);
        }
    }
}
