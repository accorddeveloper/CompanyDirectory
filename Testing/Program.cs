using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework.BackEnd;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("testing GetAllEmployees()");

            Console.WriteLine(EmployeeDataAccess.GetAllEmployees().Count);
            foreach (Employee e in EmployeeDataAccess.GetAllEmployees())
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            Console.WriteLine(EmployeeDataAccess.GetEmployeeByID(1));
            Console.WriteLine();

            Console.WriteLine("testing SearchEmployees(FirstName = 'Michael' AND Department = 'Engineering'");
            foreach (Employee e in EmployeeDataAccess.SearchEmployees("FirstName = 'Michael' AND Department = 'Engineering'"))
            {
                Console.WriteLine("Name: " + e.FirstName + " " + e.LastName);
            }

            Console.WriteLine();

            Console.WriteLine("testing SortEmployees(EmployeeDataAccess.GetAllEmployees(), FirstName, LastName DESC)");
            foreach (Employee e in EmployeeDataAccess.SortEmployees(EmployeeDataAccess.GetAllEmployees(), "FirstName, LastName DESC"))
            {
                Console.WriteLine("Name: " + e.FirstName + " " + e.LastName);
            }

            Console.ReadLine();

        }
    }
}
