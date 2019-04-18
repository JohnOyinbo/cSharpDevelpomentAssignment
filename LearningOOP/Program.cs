using HumansourceManager.HrModule;
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Car a = new Car();
            a.Brand = "Bugatti";
            a.Color = "Black";
            a.Engine = "V16";
            a.Weight = 1888;
            a.ProductionYear = 2014;
            a.Model = "Bugatti Veyron Supersport";
            a.Driving();
            Console.WriteLine(a);
            Console.ReadKey();
            Person p = new Person();
            Person p2 = new Person();
            p.Firstname = "Alfred";
            p.SetFirstname("James O.");
            WriteLine(p.GetFirstName());
            ReadKey();
           
        }
    }
}
