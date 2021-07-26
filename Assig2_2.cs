using System;

namespace Assignments
{
    class Assgmnt2_2
    {
        static void Main(string[] args)
        {

            char Grade;
            Console.WriteLine("Please, enter the grade level! (Use capital letters) ");
            Grade = Convert.ToChar(Console.ReadLine());

            // Is there a possibility to put both char in one case? ('A' || 'B') is not correct, since || doesn't work with char. 
            //  Is there any equivalent?
            
            switch (Grade)
            {
                case 'A':
                    Console.WriteLine("Perfect! You are so clever!");
                    break;
                case 'B':
                    Console.WriteLine("Perfect! You are so clever!");
                    break;
                case 'C':
                    Console.WriteLine("Good! But You can do better!");
                    break;    
                case 'D':
                    Console.WriteLine("It is not good! You should study!");
                    break;
                case 'E':
                    Console.WriteLine("It is not good! You should study!");
                    break;
                case 'F':
                    Console.WriteLine("Fail! You need to repeat the exam!");
                    break; 
                default:
                    Console.WriteLine("Please add the default case in the code!");
                    break;             
            }


        }
    }
}    