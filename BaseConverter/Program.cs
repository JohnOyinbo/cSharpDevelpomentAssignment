using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            starthere:
            Console.WriteLine("\nWelcome to my number system conversion app \n__________________________________________\nInput the number you want to convert");
            string num = Console.ReadLine();
            Console.WriteLine("Input the base of the number you want to convert");
            string n = Console.ReadLine();
            Console.WriteLine("Input the newBase");
            string newBase = Console.ReadLine();
            Console.WriteLine($"{num} in base {n} is equal to \"{ConvertNumber(num, n, newBase)} in base {newBase}\"");
            goto starthere;
            

        }


        static string ConvertNumber(string num, string n, string newBase)
        {
            // num is the number to be converted to decimal
            // n is the current base of the number to be converted
            // newBase is the number base we're converting to
            int n2 = int.Parse(n); //n2 is converting n from string type to int
            int newBase2 = int.Parse(newBase); //newBase is converting n from string type to int

            long decimalNumber = 0;


            // num = 2a5
            string digits = "0123456789ABCDEF";
            string number = num.ToUpper();
            int power = num.Length - 1;
            for (int i = 0; i < num.Length; i++)
            {
                string value = number.Substring(i, 1);
                int val = digits.IndexOf(value);
                decimalNumber += val * (long)(Math.Pow(n2, power));
                power--;

            }
           
                string finalNumber = "";


            startHere:
                if (decimalNumber > 0)
                {
                    int newDigit = (int)(decimalNumber % (long)newBase2);
                    if (newDigit >= 0)
                    {
                        char digit = digits[newDigit];
                        decimalNumber = decimalNumber / newBase2;
                        finalNumber = digit + finalNumber;
                    }

                }
                else
                {
                    return finalNumber;
                }
                goto startHere;
            }
        
    

    }
}
