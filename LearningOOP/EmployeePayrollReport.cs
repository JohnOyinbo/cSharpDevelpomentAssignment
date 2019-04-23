using HumansourceManager.HrModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LearningOOP
{
    class EmployeePayrollReport
    {
        public enum DocumentType
        {
            Pdf,Excel,Word,Rtf,Txt
        }
        public void GenerateReport(string fileName, DocumentType fileFormat)
        {
            
            string ext = ".txt";
            Employee emp = new Employee();
            var salary1 = emp.CalculateSalary();
            Employee emp2 = new Employee(EmployeeType.Contract);
            var salary2 = emp2.CalculateSalary(21);
            switch (fileFormat)
            {
                case DocumentType.Pdf:
                    ext = ".pdf";
                    break;
                case DocumentType.Excel:
                    ext = ".xls";
                    break;
                case DocumentType.Rtf:
                    ext = ".rtf";
                    break;
                case DocumentType.Word:
                    ext = ".doc";
                    break;
                case DocumentType.Txt:
                    StreamWriter Writer = File.CreateText(fileName + ext);
                    Writer.WriteLine($"salary for employee 001 id : NGN {salary2:N}");
                    Writer.WriteLine($"salary for employee 002 id : NGN {salary1:N}");
                    Writer.Flush(); 
                    Writer.Close();
                    break;
            }
        }
    }
}
