using System;

namespace Assignments
{
    class Assgmnt1_2
    {
        static void Main(string[] args)
        {
            int time;

            time = Int32.Parse(Console.ReadLine());

            if (time < 0 || time > 24)
            {
                Console.WriteLine("Invalid input. Type in value from 0 to 24");
                return;
            }
            
            if (time > 0 && time <= 12)
                {
                    Console.WriteLine("Good Morning, Sunshine!");
                }
                else if (time >= 13 && time <= 19)
                    {
                       Console.WriteLine("Good Afternoon. Work Hard!");         
                    }       
                else if (time >= 20 && time <= 24)
                    {
                        Console.WriteLine("Good Evening. Get some rest!");
                    }
            
        }
    }
}                   