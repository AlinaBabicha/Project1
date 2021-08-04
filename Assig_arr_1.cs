using System;

namespace Assignments
{
    class Arrays
    {
        static void Main(string[] args)
        {
            int[] arr = {5, 3, 7, 6, 2, 8};

            Console.WriteLine("FOR");

            for (int i=0; i<6; i++)
            {
                Console.WriteLine(arr[i]);
            }
            
            Console.WriteLine("FOREACH");

            foreach (int element in arr)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("WHILE");

            int j = 0;
            while(j < arr.Length)
            {
                Console.WriteLine(arr[j]);
                j++;
            }

            Console.WriteLine("DO WHILE");
            int l = 0;
            do
            {
                Console.WriteLine(arr[l]);
                l++;
            }
            while (l < arr.Length);

        }
    }
}