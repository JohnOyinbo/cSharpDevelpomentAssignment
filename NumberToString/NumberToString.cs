using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToString
{
    public class NumberToString
    {
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
                    a = ThreeDigitToWord(firstPart) + " thousand, " + ThreeDigitToWord(num % 1000);
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
                    a = Twodigit(firstPart) + " thousand, " + ThreeDigitToWord(num % 1000);
                }
            }
            else if (length == 1 && firstPart != 0)
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
            else
            {
                a = ThreeDigitToWord(num % 1000);
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
         public static string NumberToWords(int num)
        {
            string numb = num.ToString();
            int length = numb.Length;
            string a = "";
                if (length > 6)
                {
                    a= MillionsToWord(num);
                }
                else if (length > 3 && length <= 6)
                {
                     a = ThousandsToWord(num);
                 }
                else if (length == 3)
                {
                    a = ThreeDigitToWord(num);
                }
                else if (length == 1 || length == 2)
                {
                    a = Twodigit(num);
                }
            return a;
         }
            
    }
}
