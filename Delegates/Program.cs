using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate T ArithmeticDelegate<T> (params double[] numbers);
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticDelegate<double> arithmeticDelegateAdd = ArithmeticFunction.Add;
            ArithmeticDelegate<double> arithmeticDelegateSubtract = ArithmeticFunction.Subtract;
            ArithmeticDelegate<double> arithmeticDelegateDivide = ArithmeticFunction.Divide;
            ArithmeticDelegate<double> arithmeticDelegateMultiply = ArithmeticFunction.Multiply;
            Console.WriteLine($"The addition of all the inputed numbers gives : {arithmeticDelegateAdd(1,2,3,4)}");
            Console.WriteLine($"The Subtraction of all the inputed numbers gives : {arithmeticDelegateSubtract(1, 2, 3, 4)}");
            Console.WriteLine($"The division of all the inputed numbers gives : {arithmeticDelegateDivide(1, 2, 3, 4)}");
            Console.WriteLine($"The Multiplication of all the inputed numbers gives : {arithmeticDelegateMultiply(1, 2, 3, 4)}");
            Console.ReadLine();
        }
    }
}
