using System;
using ClassLibrary1;


namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string st;
            //Console.ReadLine(); 
            Console.WriteLine($"Hello, {args[0]}!");
            var myClass = new Class1
            {
                Age = 24,
                Name = "Harsh"
            };
            Console.WriteLine(myClass.Age);
        }
    }
}
