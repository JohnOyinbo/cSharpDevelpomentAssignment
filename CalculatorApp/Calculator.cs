using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public enum CalculatorNumbers
    {
        Num0=0,
        Num1 =1,
        Num2,Num3,Num4,Num5,Num6,Num7,Num8,Num9,
    }
    public enum CalculatorOperators
    {
        Plus, 
        Minus,
        Mul,
        Eql,
        Div,
        Decimal,
        PlusMinus,
        BackSpace,
        CE,
        C,
        Sqr,
        Sqrt
    }

    public class Calculator
    {
        public void PressNumber(CalculatorNumbers num)
        {
            lcd.Label += ((int)num).ToString();
        }

        public void PressOperator (CalculatorOperators op)
        {
            if (op == CalculatorOperators.Eql)
            {
                lcd.Result = lcd.Label;
            }
        }
       
        CalDisplay lcd = new CalDisplay() { Result ="0"}; //into wouldn't work without being instantiated
        public CalDisplay LCD
        {
            get
            {
                return lcd;
            }
        }
        // public CalculatorButton Btn9 => btn9;
        //public CalculatorButton Btn9 (alternative method)
        //{
        //    get
        //    {
        //        return btn9;
        //    }
        //}
    }
    public class CalculatorButton
    {
        public string Label { get; set; }
    }
    public class CalDisplay
    {
        public string Result { get; internal set; } = "";
        public string Label { get; set; } = "";

    }
}
