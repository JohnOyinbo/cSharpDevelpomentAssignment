using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCostingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserIdentity user1 = new UserIdentity();
            user1.CompanyInfo.Name = "jr lmt";
            Console.WriteLine(user1.CompanyInfo.Name);
            Console.ReadLine();
        }
    }
}
