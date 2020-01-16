using System;

namespace MyNameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Your Name : ");
            string userName = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Hello World!");
            Console.WriteLine("Your Name is {0}.", userName);
            Console.ReadLine();
        }
    }
}
