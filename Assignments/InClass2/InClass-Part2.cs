using System;

namespace MyNameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Your Name : ");
            string userName = Console.ReadLine();

            int userAge;
            do
            {
                Console.Write("Please Enter Your Age : ");
                userAge = Convert.ToInt32(Console.ReadLine());

                if(userAge < 0)
                {
                    Console.WriteLine("Your age can't be less than 0(zero).");
                }
            } while (userAge < 0);


            Console.WriteLine();
            Console.WriteLine("Hello World!");
            Console.WriteLine("\tYour Name is {0}.\n\tYour age is {1}", userName, userAge);
            Console.ReadLine();
        }
    }
}
