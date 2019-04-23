using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberParity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input the number you want to check whether or not is odd");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsOdd(x));
            Console.ReadLine();
            Console.WriteLine("input the number you want to check whether or not is even");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsEven(i));
            Console.ReadLine();
        }
        static bool IsOdd(int i)
        {
            bool ans;
            if (i % 2 != 0)
                ans = true;
            else
                ans = false;
            return ans;
        }
        static bool IsEven(int i)
        {
            bool ans;
            if (i % 2 == 0)
                ans = true;
            else
                ans = false;
            return ans;
        }
    }
}
