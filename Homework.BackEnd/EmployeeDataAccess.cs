using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Text;


namespace Homework.BackEnd
{
    public static class EmployeeDataAccess
    {
        //change file path
        public static AbstractEmployeeDataAccess accessor
                = new EmployeeXmlDataAccess("C:\\Users\\Katharine\\Desktop\\Wonderlic_HW\\Homework.FrontEnd\\App_Data\\Employees.xml");


        public static Employee GetEmployeeByID(int employeeID)
        {
            return accessor.GetEmployeeByID(employeeID);
        }


        public static List<Employee> GetAllEmployees()
        {
            try
            {
                return accessor.GetAllEmployees();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<Employee>();
            }
        }

        public static List<Employee> SearchEmployees(string searchString)
        {
            // Assume searchString is a list of one or more search expressions seperated by an "AND" string.
            // Each search expression is a field, followed by an "=", followed by a search value.
            // A search value may contain a "%" that is a wildcard symbol.
            // All search comparisons should ignore case.
            //
            // eg. FirstName='Ben' AND LastName='A%t'

            try
            {

                return accessor.SearchEmployees(searchString);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<Employee>();
            }

        }

        public static List<Employee> SortEmployees(List<Employee> employees, string sortString)
        {
            // Assume sortString is a comma seperated list.
            // Each field can potentially be followed by an ASC or DESC.
            // Assume ASC if nothing is defined.
            //
            // eg. FirstName, LastName DESC
            try
            {
                return accessor.SortEmployees(employees, sortString);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<Employee>();
            }
        }
    }
}
