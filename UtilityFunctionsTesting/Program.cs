using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JohnWhiteUtilityFunctions.UtilityFunctions;
using static System.Console;

namespace UtilityFunctionsTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(NumberParity.IsOdd(5));
            WriteLine(NumberToString.NumberToWords(520122484548));
            WriteLine(GradingFunction.Grade(56));
            WriteLine(BaseConverter.ConvertNumber("985",10,16));
            ReadLine();
        }
    }
}
