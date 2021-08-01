using System;

namespace Assignments
{
    class Assgmnt2_3
    {
        public static bool ValidateOperator(char operatorProvided)
        {
        if (operatorProvided != '*' &&
        operatorProvided != '+' && operatorProvided != '/'
        && operatorProvided != '-' &&
        operatorProvided != '%' && !char.IsLetter('p') && !char.IsLetter('b') && !char.IsLetter('s'))
            return false;
        else
            return true;                        
        }

        public static void ErrorMessage()
        {
            Console.WriteLine("Input is incorrect!");
        }
        static void Main(string[] args)
        {
            double value1 = 0;
            bool inputCorrect = false;

            while (!inputCorrect)
            {
                Console.WriteLine("Please, enter the first value");
                if (Double.TryParse(Console.ReadLine(), out value1))
                    inputCorrect = true;
                else
                {
                    ErrorMessage();
                }
            }

            double value2 = 0;
            inputCorrect = false;

             while (!inputCorrect)
            {
                Console.WriteLine("Please, enter the second value");
                if (Double.TryParse(Console.ReadLine(), out value2))
                    inputCorrect = true;
                else
                {
                    ErrorMessage();
                }
            }

            inputCorrect = false;
            char operation = ' ';

            while (!inputCorrect)
            {
                Console.WriteLine("Please, choose the operation: '+' sum , '-' substraction , '/' division \n'*' multiplication , '%' modulo , 'p' print both , \n'b' verify the greater , 's' verify the smaller");
                operation = Char.Parse(Console.ReadLine());

                    if (ValidateOperator(operation))
                        break;
                    else
                        ErrorMessage();
            }

            switch (operation)
            {
                case '+':               
                    Console.WriteLine($" {value1} + {value2} = " + (value1 + value2));
                    break;                  
                case '-':               
                    Console.WriteLine($" {value1} - {value2} = " + (value1 - value2));
                    break;               
                case '/':                   
                    Console.WriteLine($" {value1} / {value2} = " + (value1 / value2));
                    break;                         
                case '*':
                    Console.WriteLine($" {value1} * {value2} = " + (value1 * value2));
                    break;                        
                case '%' :           
                    Console.WriteLine($" {value1} % {value2} = " + (value1 % value2));
                    break;
                case 'p' :
                    Console.WriteLine($" Value 1 : {value1} , Value 2 : {value2}");
                    break;
                case 'b' :
                    Console.WriteLine ($"Value " + Math.Max(value1, value2) + " is greater");
                    break;
                case 's' :
                    Console.WriteLine ($"Value " + Math.Min(value1, value2) + " is smaller");
                    break;
                default:
                    Console.WriteLine("Input incorrect!");
                    break;      
            }
        }
    }
}           