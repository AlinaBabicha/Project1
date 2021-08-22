using System;

namespace Assignments
{
    class Arrays
    {

        static void Main(string[] args)
        {
            byte[] grades = new byte[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Please, enter the element: ");

                while (true)
                {
                    if (Byte.TryParse(Console.ReadLine(), out grades[i]) && grades[i] >= 0 && grades[i] <= 10)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input! Please, try again!");
                    }
                }
            }

            int countFailed = 0;

            foreach (byte grade in grades)
            {
                if (grade < 4)
                    countFailed++;
            }
            Console.WriteLine(countFailed + " students have failed the exam");

            int countA = 0;

            foreach (byte grade in grades)
            {
                if (grade == 10)
                    countA++;
            }
            Console.WriteLine(countA + " students have got an A grade for the exam");

            int[] histogram = new int[10];

            foreach (byte grade in grades)
            {
                histogram[grade - 1]++;
            }

            for (int i = 0; i < histogram.Length; i++)
            {
                Console.WriteLine("\n" + histogram[i] + " students with the grade " + (i + 1));
            }
        }

    }
}