using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansourceManager.HrModule
{
    public class AppConstants
    {
        //Employee Type
       public const string EMPLOYEE_TYPE_CONTRACT = "CONTRACT";
       public const string EMPLOYEE_TYPE_PERMANENT = "PERMANENT";
       public const string EMPLOYEE_TYPE_INTERN = "INTERN";
        // GENDER
       public const string GENDER_MALE = "MALE";
       public const string GENDER_FEMALE = "FEMALE";

    }
    public enum Gender
    {
        Male =10,
        Female = 20
    };
    public enum EmployeeType
    {
        Contract,Permanent,Intern
    }
    public class Employee
    {
        public Employee(EmployeeType empType)
        {
            Group = empType;
        }
        public Employee()
        {
            Group = EmployeeType.Permanent;
        }
        public Gender Gender { get; set; } = Gender.Male;
        public EmployeeType Group { get; set; } 
        //Methods and parameters
        public decimal CalculateSalary(int noOfDays=0)
        {
            noOfDays = noOfDays < 0 ? 0 : noOfDays;
            decimal res = 0.0m;
            switch (Group)
            {
                case EmployeeType.Contract:
                    res = 15000 * noOfDays;
                    break;
                case EmployeeType.Permanent:
                    res = 20000 * noOfDays;
                    break;
                case EmployeeType.Intern:
                    res = 5000 * noOfDays;
                    break;
            }
            return res;
        }
    }
}
