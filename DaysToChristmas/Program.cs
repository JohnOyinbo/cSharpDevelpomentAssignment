using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysToChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime christmasDate = new DateTime(2019,12,25);
            var daysToChristmas = christmasDate.Subtract(DateTime.Today).Days;
            Console.WriteLine($"There are {daysToChristmas} days to Christmas");
            Console.WriteLine($"There are {Months(daysToChristmas)} to christmas");
            Console.ReadLine();

        }
        static string Months(int days)
        {
            int months = days / 30;
            int remainingDays = days % 30;
            string a = $"{months} months and {remainingDays} days";
            return a;
            
        }
    }
}
