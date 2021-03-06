﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Numbers
    {
        public  double[] numbers { get; set; }
    }
    public class ArithmeticFunction
    {
        public static double Add(params double[] numbers)
        {
            double result = 0;
            foreach (var number in numbers)
            {
                result += number;
            }
            return result;
        }
        public static double Subtract(params double[] numbers)
        {
            double result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }
            return result;
        }
        public static double Multiply(params double[] numbers)
        {
            double result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result *= numbers[i];
            }
            return result;
        }
        public static double Divide(params double[] numbers)
        {
            double result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result /= numbers[i];
            }
            return result;
        }
    }
}
