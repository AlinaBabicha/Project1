using System;
using System.Text.RegularExpressions;

namespace Regexs
{
    class AssigString
    {
        static void Main(string[] args)
        {
            /*string userInputstring;
            string palindromeVar;
           
            Console.WriteLine("Please, enter the palindrome:");
            userInputstring = Console.ReadLine().ToLower();

            userInputstring = Regex.Replace(userInputstring, "[^a-z0-9]" , "");

            for(int i = userInputstring.Length; i>0; i--)
            {
                Console.WriteLine("The reverse option is " + userInputstring[i-1]);

               if (userInputstring [i-1] == userInputstring [i])
               {
                   Console.WriteLine("Yes, this is a palindrome.");
               }
               else
               {
                   Console.WriteLine("No, it is not a palindrome. The reveresed variants for your input is" + userInputstring[i-1]);
               }
            }*/

            string userInputText;
            Console.WriteLine("Please, enter the text for check: ");
            userInputText = Console.ReadLine().ToLower();

            userInputText = Regex.Replace(userInputText, "[^a-z0-9]", "");

            bool palindrome = true;

            for (int i=0; i < userInputText.Length/2; i++)
            {
                if(userInputText[i] != userInputText[userInputText.Length-i-1])
                {
                    palindrome = false;
                    break;
                }    
            }

            Console.WriteLine(palindrome ? "This is a palindrome" : "This is not a palindrome");


        }
    }
}            