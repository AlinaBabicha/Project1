using System;

namespace Assignments
{
    class Assgmnt2_1
    {
        static void Main(string[] args)
        {
            int WeekDayNumber;

            Console.WriteLine("Please, enter the number of the day:");

            
            if (!Int32.TryParse(Console.ReadLine(), out WeekDayNumber))
            {
                Console.WriteLine("Please add correct verification in the code!");
            } 

            switch (WeekDayNumber)
            {
                case 1:
                    Console.WriteLine("It is a wroking day");
                    break;
                case 2:
                    Console.WriteLine("It is a wroking day");
                    break;
                case 3:
                    Console.WriteLine("It is a wroking day");
                    break;
                case 4:
                    Console.WriteLine("It is a wroking day");
                    break;
                case 5:
                    Console.WriteLine("It is a wroking day");
                    break;
                case 6:
                    Console.WriteLine("It is holiday");
                    break;
                case 7:
                    Console.WriteLine("It is holiday");
                    break;   
                default:
                    Console.WriteLine("Please add correct verification in the code!");
                    break;                         
            }

        }
    }
}