using System;

namespace MyArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new[] { 82, 93, 29, 45, 78, 45, 65, 79, 12, 15, 74, 34, 16, 49, 52 };
            Console.WriteLine("\nUnsorted Array >");

            for(int x = 0; x < intArray.Length; x++)
            {
                Console.Write("{0}\t", intArray[x]);
            }

            Array.Sort(intArray);
            Console.WriteLine("\n\nSorted Array >");

            foreach(int element in intArray)
            {
                Console.Write("{0}\t", element);
            }


            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
