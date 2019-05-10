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
            ArithmeticDelegate<double> arithmeticDelegate = ArithmeticFunction.Add;
            arithmeticDelegate += ArithmeticFunction.Subtract;
            arithmeticDelegate += ArithmeticFunction.Divide;
            arithmeticDelegate += ArithmeticFunction.Multiply;
            arithmeticDelegate(1,2,3,4);
            Console.ReadLine();
        }
    }
}
