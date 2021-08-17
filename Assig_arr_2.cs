using System;

namespace Assignments
{
    class Arrays
    {
        
        static void Main(string[] args)
        {
           int i = 0;
           int j = 0;
           int[] arr = {10, 4, -4, 7, 0, 9, 1, 3, 7, -5};

            Console.WriteLine("Negative elements are: ");
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Odd elements are:");
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                    Console.Write(arr[i] + " ");
            }
            Console.WriteLine();     

            Console.WriteLine("The count of odd elements is:");
            int count = 0;
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                count++;
            }
            Console.WriteLine(count);   

            Console.WriteLine("The count of elements with the same vaule is:");
            
            int countOfMultiple = 0;
            for (i = 0; i < arr.Length; i++)
            {
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        countOfMultiple++;
                        break;
                    }
                }
            }
            Console.WriteLine(countOfMultiple); 

            Console.WriteLine("Every second element of the array:");
            
            for (i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                Console.Write(arr[i] + " ");
                }
            }
           
           Console.WriteLine("\nAverage value of the array is: " );

           double sum = 0;
           foreach (int element in arr)
           {
                sum += element;
           }
            Console.WriteLine(sum/arr.Length); 

            int countOfElements = 0;
            foreach (int element in arr)
            {
                if (element < (sum/arr.Length))
                {
                    countOfElements++;
                }
            }
            Console.WriteLine("\n" + countOfElements + " elements are smaller than average value of the array");
        }
    }
}