using System;

namespace MyArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            int[] intArray = new[] { 82, 93, 29, 45, 78, 45, 65, 79, 12, 15, 74, 34, 16, 49, 52 };
            Console.WriteLine("\nUnsorted Array >");

            for (int x = 0; x < intArray.Length; x++)
            {
                Console.Write("{0}\t", intArray[x]);
            }

            Array.Sort(intArray);
            Console.WriteLine("\n\nSorted Array >");

            foreach (int element in intArray)
            {
                Console.Write("{0}\t", element);
            }


            // Part 2

            var implicitArray = new[] { 82, 93, 29, 45, 78 };

            Console.WriteLine("Implicit Array > ");
            for(int x = 0; x < implicitArray.Length; x++)
            {
                Console.Write("{0}\t", implicitArray[x]);
            }

            Console.WriteLine("\n\nMultiDimensional Array > ");

            int matrix_M = 4;
            int matrix_N = 4;

            char[,] alphabetMatrix = new char[matrix_M, matrix_N];
            
            alphabetMatrix[0, 0] = 'A';
            alphabetMatrix[0, 1] = 'B';
            alphabetMatrix[0, 2] = 'C';
            alphabetMatrix[0, 3] = 'D';
            alphabetMatrix[1, 0] = 'E';
            alphabetMatrix[1, 1] = 'F';
            alphabetMatrix[1, 2] = 'G';
            alphabetMatrix[1, 3] = 'H';
            alphabetMatrix[2, 0] = 'I';
            alphabetMatrix[2, 1] = 'J';
            alphabetMatrix[2, 2] = 'K';
            alphabetMatrix[2, 3] = 'L';
            alphabetMatrix[3, 0] = 'M';
            alphabetMatrix[3, 1] = 'N';
            alphabetMatrix[3, 2] = 'O';
            alphabetMatrix[3, 3] = 'P';


            for(int m = 0; m < matrix_M; m++)
            {
                for(int n = 0; n < matrix_N; n++)
                {
                    Console.WriteLine("myArray[{0}][{1}] has the value of {2}", m, n, alphabetMatrix[m, n]);
                }
            }



            // Part 3

            Console.WriteLine("\n\n");

            int numberOfDetailsInBio = 4;
            object[] userBioObjectArray = new object[numberOfDetailsInBio];

            userBioObjectArray[0] = "AjaiVeer";
            userBioObjectArray[1] = 25;
            userBioObjectArray[2] = 'M';
            userBioObjectArray[3] = 61.39;

            Console.WriteLine("My Name is {0}. I am {1} years old. My gender is {2}. I have ${3} in my bank account.", userBioObjectArray[0], userBioObjectArray[1], userBioObjectArray[2], userBioObjectArray[3]);

   
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
