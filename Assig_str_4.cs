using System;
using System.Text.RegularExpressions;

namespace Regexs
{
    class AssigString
    {
        static void Main(string[] args)
        {

            string name = "John";

            if (Regex.IsMatch(name, "^[A-aZ-z]+$"))
            {
                Console.WriteLine("This string contains a name");
            }
            else
            {
                Console.WriteLine("This string does not contain a name");
            }

            string username = "s20surname";

            if (Regex.IsMatch(username, "^[A-zA-z][0-9]{2}[A-zA-a]+$"))
            {
                Console.WriteLine("The username pattern is correct");
            }
            else
            {
                Console.WriteLine("The username pattern is incorrect");
            }

            string personCodeOfLatvian = "121200-11311";

            if (Regex.IsMatch(personCodeOfLatvian, @"^[0-9]{6}(\s-\s|-)[0-9]{5}$"))
            {
                Console.WriteLine("The person code pattern is correct");
            }
            else
            {
                Console.WriteLine("The person code pattern is incorrect");
            }

        }
    }
}