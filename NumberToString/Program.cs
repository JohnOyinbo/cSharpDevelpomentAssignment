using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToString
{
    class Program
    {
        static void Main(string[] args)
        {
            starthere:
            Console.WriteLine("kindly input a number");
            bool success = int.TryParse(Console.ReadLine(), out int numb);
            if (success)
            {

                int num = numb.ToString().Length;
                if (num>6)
                {
                    Console.WriteLine(MillionsToWord(numb));
                }
                else if (num > 3 && num <=6)
                {
                    Console.WriteLine(ThousandsToWord(numb));
                }
                else if (num == 3)
                {
                    Console.WriteLine(ThreeDigitToWord(numb));
                }
                else if (num == 1 || num == 2)
                {
                    Console.WriteLine(Twodigit(numb));
                }
            }
            Console.ReadLine();
            goto starthere;
        }
        public static String[] ones = { "", "one", "two", "three", "four", "five",
            "six", "seven", "eight", "nine", "ten", "eleven", "twelve",
            "thirteen", "fourteen", "fifteen", "sixteen", "seventeen",
            "eighteen", "nineteen" };
        public static String[] tens = { "", "ten", "twenty", "thirty", "forty", "fifty",
            "sixty", "seventy", "eighty", "ninety" };

        static string Twodigit(int num)
        {
            string a = "";
            if (num < 20)
            {
                a = ones[num];
            }
            else
            {
                int firstDigit, secondDigit;
                secondDigit = num % 10;
                firstDigit = num / 10;
                a = tens[firstDigit] + " " + ones[secondDigit];
            }
            return a;
        }
        static string ThreeDigitToWord(int num)
        {          
            string a = "";
            string x = num.ToString();
            int y = x.Length;
            if (y >= 3)
            {
                int firstDigit = num / 100;
                if (num % 100 == 0)
                    a = ones[firstDigit] + " hundred ";
                else
                {
                    int lastTwoDigit = num % 100;

                    a = ones[firstDigit] + " hundred and " + Twodigit(lastTwoDigit);
                }
            }
            else
            {
                a = Twodigit(num);
            }
            
            return a;
        }
        static string ThousandsToWord(int num)
        {
            string a = "";

            int firstPart = num / 1000;
            string b = firstPart.ToString();
            int length = b.Length;
            if (length == 3)
            {
                if (num % 1000 == 0)
                {
                    a = ThreeDigitToWord(firstPart) + " thousand";
                }
                else 
                {
                    a = ThreeDigitToWord(firstPart) + " thousand, " +  ThreeDigitToWord(num % 1000);
                }
               

            }
            else if (length == 2) 
            {
                if (num % 1000 == 0)
                {
                    a = Twodigit(firstPart) + " thousand";
                }
                else
                {
                    a = Twodigit(firstPart) + " thousand, " +  ThreeDigitToWord(num % 1000);
                }
            } 
            else if (length == 1)
            {
                if (num % 1000 == 0)
                {
                    a = Twodigit(firstPart) + " thousand";
                }
                else
                {
                    a = Twodigit(firstPart) + " thousand, " + ThreeDigitToWord(num % 1000);
                }
            }
            return a;
        }
        static string MillionsToWord(int num)
        {
            string a = "";
            int firstPart = num / 1000000;
            string b = firstPart.ToString();
            int length = b.Length;
            if (length == 3)
            {
                if (num % 1000000 == 0)
                {
                    a = ThreeDigitToWord(firstPart) + "million";
                }
                else
                {
                    a = ThreeDigitToWord(firstPart) + " million, " + ThousandsToWord(num % 1000000);
                }
            }
            else if (length <= 2)
            {
                if (num % 1000000 == 0)
                {
                    a = Twodigit(firstPart) + " million";
                }
                else
                {
                    a = Twodigit(firstPart) + " million, " + ThousandsToWord(num % 1000000);
                }
            }
            return a;
        }
    }
 }


