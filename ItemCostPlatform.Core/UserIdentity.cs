using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCostingApp
{
    public class UserIdentity
    {
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public UserCompany CompanyInfo { get; internal set; }
        public UserIdentity()
        {
            CompanyInfo = new UserCompany();
        }
        public UserIdentity(string firstName, string lastName) : this()
        {
            FirstName = firstName;
            LastName = lastName;

        }
    }
    
    
}
