using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework.BackEnd
{
    public abstract class AbstractEmployeeDataAccess
    {

        public abstract List<Employee> GetAllEmployees();
        public abstract Employee GetEmployeeByID(int employeeID);
        public abstract List<Employee> SearchEmployees(string searchString);
        public abstract List<Employee> SortEmployees(List<Employee> employees, string sortString);
        //public abstract List<Employee> SortEmployees2(List<Employee> employees, string sortString);
        //public abstract List<Employee> SortEmployees3(List<Employee> employees, string sortString);

    }
}
