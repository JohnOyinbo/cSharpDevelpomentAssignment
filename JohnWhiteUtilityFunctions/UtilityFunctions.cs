﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnWhiteUtilityFunctions
{
    public class UtilityFunctions
    {
        public class NumberToString
        {
            public static String[] ones = { "", "One", "Two", "Three", "Four", "Five",
            "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve",
            "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen",
            "Eighteen", "Nineteen" };
            public static String[] tens = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty",
            "Sixty", "Seventy", "Eighty", "Ninety" };

            static string Twodigit(long num)
            {
                string a = "";
                if (num < 20)
                {
                    a = ones[num];
                }
                else
                {
                    long firstDigit, secondDigit;
                    secondDigit = num % 10;
                    firstDigit = num / 10;
                    a = tens[firstDigit] + " " + ones[secondDigit];
                }
                return a;
            }
            static string ThreeDigitToWord(long num)
            {
                string a = "";
                string x = num.ToString();
                int y = x.Length;
                if (y >= 3)
                {
                    long firstDigit = num / 100;
                    if (num % 100 == 0)
                        a = ones[firstDigit] + " hundred ";
                    else
                    {
                        long lastTwoDigit = num % 100;

                        a = ones[firstDigit] + " hundred and " + Twodigit(lastTwoDigit);
                    }
                }
                else
                {
                    a = Twodigit(num);
                }

                return a;
            }
            static string ThousandsToWord(long num)
            {
                string a = "";

                long firstPart = num / 1000;
                string b = firstPart.ToString();
                int length = b.Length;
                if (length == 3)
                {
                    if (num % 1000 == 0)
                    {
                        a = ThreeDigitToWord(firstPart) + " thousand";
                    }

                    else if (num % 1000 != 0 && num % 1000 < 100)
                        a = ThreeDigitToWord(firstPart) + " thousand and " + ThreeDigitToWord(num % 1000);
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
                    else if (num % 1000 != 0 && num % 1000 < 100)
                        a = ThreeDigitToWord(firstPart) + " thousand and " + ThreeDigitToWord(num % 1000);
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
                    else if (num % 1000 != 0 && num % 1000 < 100)
                        a = ThreeDigitToWord(firstPart) + " thousand and " + ThreeDigitToWord(num % 1000);
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
            static string MillionsToWord(long num)
            {
                string a = "";
                long firstPart = num / 1000000;
                string b = firstPart.ToString();
                int length = b.Length;
                if (length == 3)
                {
                    if (num % 1000000 == 0)
                    {
                        a = ThreeDigitToWord(firstPart) + " million";
                    }
                    else if (num % 1000000 != 0 && num % 1000000 < 100)
                        a = ThreeDigitToWord(firstPart) + " million and " + ThreeDigitToWord(num % 1000000);
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
                    else if (num % 1000000 != 0 && num % 1000000 < 100)
                        a = ThreeDigitToWord(firstPart) + " million and " + ThreeDigitToWord(num % 1000000);
                    else if (length == 1 && firstPart == 0)
                    {
                        a = ThousandsToWord(num % 1000000000);
                    }
                    else
                    {
                        a = Twodigit(firstPart) + " million, " + ThousandsToWord(num % 1000000);
                    }
                }

                return a;
            }
            static string BillionsToWord(long num)
            {
                string a = "";
                long firstPart = num / 1000000000;
                string b = firstPart.ToString();
                int length = b.Length;
                if (length == 3)
                {
                    if (num % 1000000000 == 0)
                    {
                        a = ThreeDigitToWord(firstPart) + " billion";
                    }
                    else if (num % 1000000000 != 0 && num % 1000000000 < 100)
                        a = ThreeDigitToWord(firstPart) + " billion and " + ThreeDigitToWord(num % 1000000000);
                    else
                    {
                        a = ThreeDigitToWord(firstPart) + " billion, " + MillionsToWord(num % 1000000000);
                    }
                }
                else if (length <= 2)
                {
                    if (num % 1000000000 == 0)
                    {
                        a = Twodigit(firstPart) + " billion";
                    }
                    else if (num % 1000000000 != 0 && num % 1000000000 < 100)
                        a = ThreeDigitToWord(firstPart) + " billion and " + ThreeDigitToWord(num % 1000000000);
                    else if (length == 1 && firstPart == 0)
                    {
                        a = MillionsToWord(num % 1000000000);
                    }
                    else
                    {
                        a = Twodigit(firstPart) + " billion, " + MillionsToWord(num % 1000000000);
                    }
                }
                return a;
            }
            static string TrillionsToWord(long num)
            {
                string a = "";
                long firstPart = num / 1000000000000;
                string b = firstPart.ToString();
                int length = b.Length;
                if (length == 3)
                {
                    if (num % 1000000000000 == 0)
                    {
                        a = ThreeDigitToWord(firstPart) + " trillion";
                    }
                    else if (num % 1000000000000 != 0 && num % 1000000000000 < 100)
                        a = ThreeDigitToWord(firstPart) + " trillion and " + ThreeDigitToWord(num % 1000000000000);
                    else
                    {
                        a = ThreeDigitToWord(firstPart) + " trillion, " + BillionsToWord(num % 1000000000000);
                    }
                }
                else if (length <= 2)
                {
                    if (num % 1000000000000 == 0)
                    {
                        a = Twodigit(firstPart) + " trillion";
                    }
                    else if (num % 1000000000000 != 0 && num % 1000000000000 < 100)
                        a = ThreeDigitToWord(firstPart) + " trillion and " + ThreeDigitToWord(num % 1000000000000);
                    else
                    {
                        a = Twodigit(firstPart) + " trillion, " + BillionsToWord(num % 1000000000000);
                    }
                }
                return a;
            }
             public static string NumberToWords(long num)
            {
                string numb = num.ToString();
                int length = numb.Length;
                string a = "";
                if (length > 12)
                {
                    a = TrillionsToWord(num);
                }
                else if (length > 9 && length <= 12)
                {
                    a = BillionsToWord(num);
                }
                else if (length > 6 && length <= 9)
                {
                    a = MillionsToWord(num);
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
        public class GradingFunction
        {
            public static string Grade(int score)
            {

                string grade;
                grade = (score >= 80 && score < 101) ? "A" :
                (score >= 65 && score < 79) ? "AB" :
                (score >= 55 && score < 65) ? "B" :
                (score >= 45 && score < 55) ? "C" :
                (score >= 35 && score < 45) ? "CD" :
                (score >= 25 && score < 35) ? "D" :
                (score >= 15 && score < 25) ? "E" :
                (score >= 0 && score < 15) ? "F" :
                "invalid";
                return grade;

            }
        }
        public class NumberParity
        {
            public static bool IsOdd(int i)
            {
                bool ans;
                if (i % 2 != 0)
                    ans = true;
                else
                    ans = false;
                return ans;
            }
            public static bool IsEven(int i)
            {
                bool ans;
                if (i % 2 == 0)
                    ans = true;
                else
                    ans = false;
                return ans;
            }
        }
        public class BaseConverter
        {
            public static string ConvertNumber(string num, int n, int newBase)
            {
                // num is the number to be converted
                // n is the current base of the number to be converted
                // newBase is the number base we're converting to
                if (IsNumberValid(num, n))
                {
                    long decimalNumber = 0;

                    // num = 2a5
                    string digits = "0123456789ABCDEF";
                    string number = num.ToUpper();
                    int power = num.Length - 1;
                    for (int i = 0; i < num.Length; i++)
                    {
                        string value = number.Substring(i, 1);
                        int val = digits.IndexOf(value);
                        decimalNumber += val * (long)(Math.Pow(n, power));
                        power--;

                    }

                    string finalNumber = "";


                startHere:
                    if (decimalNumber > 0)
                    {
                        int newDigit = (int)(decimalNumber % (long)newBase);
                        if (newDigit >= 0)
                        {
                            char digit = digits[newDigit];
                            decimalNumber = decimalNumber / newBase;
                            finalNumber = digit + finalNumber;
                        }

                    }
                    else
                    {
                        return finalNumber;
                    }
                    goto startHere;


                }
                else
                    return "invalid input";
                
            }
            static bool IsNumberValid(string num, int n)
            {
                string digits = "0123456789ABCDEF";
                string number = num.ToUpper();
                bool a = true;
                for (int i = 0; i < num.Length; i++)
                {
                    string value = number.Substring(i, 1);
                    int val = digits.IndexOf(value);
                    a = a && (val >= n);
                }
                return a;
            }

            }
    }
}
