using System;

namespace CsharpClass
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public void Introduce()
        {
            Console.WriteLine("My name is" + FirstName + "and"+ LastName );
        }
    }
}
