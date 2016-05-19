using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Text;
using System.Xml.Linq;

namespace Homework.BackEnd
{
    class EmployeeXmlDataAccess : AbstractEmployeeDataAccess
    {
        private IEnumerable<Employee> employees;

        //constructor for employees object
        public EmployeeXmlDataAccess(string filename)
        {
            employees = from employee in XDocument.Load(filename).Element("Employees").Elements("Employee")
                        select new Employee
                        {
                            EmployeeID = int.Parse(employee.Element("EmployeeID").Value),
                            FirstName = employee.Element("FirstName").Value,
                            LastName = employee.Element("LastName").Value,
                            Title = employee.Element("Title").Value,
                            Department = employee.Element("Department").Value,
                            Extension = int.Parse(employee.Element("Extension").Value)
                        };
        }

        //return all employees
        public override List<Employee> GetAllEmployees()
        {
            return employees.ToList();
        }

        //return the first employee found with corresponding employeeID
        public override Employee GetEmployeeByID(int employeeID)
        {
            var employee = employees.Where(e => e.EmployeeID == employeeID);

            if (employee.Count() == 1)
                return employee.First();

            // if there is either no employee with this id or more than 1
            return null;
        }

        //query employees by parameters of lastName, firstName, &/Or Department 
        public override List<Employee> SearchEmployees(string searchString)
        {
            searchString = searchString.Replace("'", "\"");
            var emp = employees.AsQueryable().Where(searchString).ToList();
            return emp;
        }

        //sort is currently defaulted to LastName -- change in Default.aspx.cs file
        public override List<Employee> SortEmployees(List<Employee> employees, string sortString)
        {
            return employees.AsQueryable().OrderBy(sortString).ToList();
        }

    }
}
