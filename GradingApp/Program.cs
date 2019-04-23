using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your score here: ");
            int score = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your grade is {0}", Grade(score));
            Console.ReadLine();
        }
        static string Grade(int score)
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
}
