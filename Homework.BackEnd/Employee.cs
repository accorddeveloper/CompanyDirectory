using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework.BackEnd
{
    public class Employee
    {
        internal Employee() { }

        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public int Extension { get; set; }

        public override string ToString()
        {
            return EmployeeID + " " + FirstName + " " + LastName;
        }
    }


}
