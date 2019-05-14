using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new MyClass1() { Numbers = 15 };
            var c2 = new MyClass2() { Numbers = 20 };
            var c3 = new MyClass2() { Numbers = 05 };
            var c4 = new MyClass2() { Numbers = 05 };
            var c5 = new MyClass2() { Numbers = 2 };

            var number = new MyClass2[] { c2, c3, c4, c5 };
            foreach (var digit in number)
            {
                c1 *= digit;
            }
            Console.WriteLine(c1.Numbers);
            Console.ReadLine();
        }
    }
    public class MyClass1
    {
        public int Numbers { get; set; }
        public static MyClass1 operator + (MyClass1 myClass1, MyClass2 myClass2) 
        {
            var a = myClass1.Numbers + myClass2.Numbers;
            return new MyClass1 { Numbers = a };
        }
        public static MyClass1 operator - (MyClass1 myClass1, MyClass2 myClass2)
        {
            var a = myClass1.Numbers - myClass2.Numbers;
            return new MyClass1 { Numbers = a };
        }
        public static MyClass1 operator  * (MyClass1 myClass1, MyClass2 myClass2)
        {
            var a = myClass1.Numbers * myClass2.Numbers;
            return new MyClass1 { Numbers = a };
        }
        public static MyClass1 operator ++ (MyClass1 myClass1)
        {
            var a = myClass1.Numbers + 1;
            return new MyClass1 { Numbers = a };
        }
        public static MyClass1 operator -- (MyClass1 myClass1)
        {
            var a = myClass1.Numbers - 1;
            return new MyClass1 { Numbers = a };
        }
    }
    public class MyClass2
    {
        public int Numbers { get; set; }
        public static MyClass2 operator +(MyClass2 myClass2, MyClass1 myClass1)
        {
            var a = myClass2.Numbers + myClass1.Numbers;
            return new MyClass2 { Numbers = a };
        }
        public static MyClass2 operator - (MyClass2 myClass2, MyClass1 myClass1)
        {
            var a = myClass2.Numbers - myClass1.Numbers;
            return new MyClass2 { Numbers = a };
        }
        public static MyClass2 operator * (MyClass2 myClass2, MyClass1 myClass1)
        {
            var a = myClass2.Numbers * myClass1.Numbers;
            return new MyClass2 { Numbers = a };
        }
        public static MyClass2 operator ++ (MyClass2 myClass2)
        {
            var a = myClass2.Numbers + 1;
            return new MyClass2 { Numbers = a };
        }
        public static MyClass2 operator -- (MyClass2 myClass2)
        {
            var a = myClass2.Numbers - 1;
            return new MyClass2 { Numbers = a };
        }



    }
}
