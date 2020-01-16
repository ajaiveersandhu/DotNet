using System;

namespace MyHelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Hello World!");
            Console.WriteLine("My name is AjaiVeer.");
            Console.Title = "InClass1";
            Console.ReadLine();
        }
    }
}
