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

            DateTime dateTime = new DateTime(2019, 1, 1);

            Console.WriteLine();
            Console.WriteLine("Hello World!");
            Console.WriteLine("\tYour Name is {0}.", userName);
            Console.WriteLine("\tYour age is {0}", userAge);
            
            for(int userAgeYearly = 0; userAgeYearly <= userAge; userAgeYearly++)
            {   
                Console.WriteLine("\tIn year {0}, you were {1} years old.", (dateTime.Year - userAge), userAgeYearly);
                dateTime = dateTime.AddYears(1);
            }

            Console.ReadLine();
        }
    }
}
