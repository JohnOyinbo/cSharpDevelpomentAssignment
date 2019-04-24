using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansourceManager.HrModule
{
    public class Person
    {

        private float height;
        private string firstName;
        private string lastname ;
        private int age =10;
        public int Age { get => age; set => age=value; }
        public void SetFirstname(string newName)
        {
            this.firstName = newName;
        }
        public string GetFirstName()
        {
            return firstName;
        }
        public string Firstname
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
      
        public float Height
        {
            get
            {
                return height; // Readonly
            }
            set
            {
                height = value;
            }

        }
       


    }
}
