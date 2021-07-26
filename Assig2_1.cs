using System;

namespace Assignments
{
    class Assgmnt2_1
    {
        static void Main(string[] args)
        {
            int WeekDayNumber;

            Console.WriteLine("Please, enter the number of the day:");
            WeekDayNumber = Int32.Parse(Console.ReadLine());

            /*
            if (!Int32.TryParse(Console.ReadLine(), out WeekDayNumber) || WeekDayNumber > 7 || WeekDayNumber < 0 )
            {
                Console.WriteLine("Please add correct verification in the code!");
            } ---> if I use this option, instead of default, when executing the code I have to type twice, in order fot the code to verify, whether
                   entered value is correct. Why is it like that and how can I get rid of this extra line? Where is my mistake?*/

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