using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Homework.BackEnd;
using System.Data;

namespace Homework.FrontEnd
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }


        protected void SearchButton_Click(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            SearchFirstName.Text = string.Empty;
            SearchLastName.Text = string.Empty;
            SearchDepartment.Text = string.Empty;
            PopulateGridView();
        }


        private void PopulateGridView()
        {

            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            List<Employee> employees;
            String lastName = SearchLastName.Text;
            String lastNameProp = myTI.ToTitleCase(lastName);
            String firstName = SearchFirstName.Text;
            String firstNameProp = myTI.ToTitleCase(firstName);
            String department = SearchDepartment.Text;
            String departmentProp = myTI.ToTitleCase(department);
            int n = 0;

            if (string.IsNullOrEmpty(lastNameProp) && !string.IsNullOrEmpty(firstNameProp) && !string.IsNullOrEmpty(departmentProp))
                n = 1;
            if (string.IsNullOrEmpty(lastNameProp) && string.IsNullOrEmpty(firstNameProp) && !string.IsNullOrEmpty(departmentProp))
                n = 2;
            if (string.IsNullOrEmpty(lastNameProp) && string.IsNullOrEmpty(firstNameProp) && string.IsNullOrEmpty(departmentProp))
                n = 3;
            if (string.IsNullOrEmpty(firstNameProp) && !string.IsNullOrEmpty(lastNameProp) && !string.IsNullOrEmpty(departmentProp))
                n = 4;
            if (string.IsNullOrEmpty(departmentProp) && !string.IsNullOrEmpty(lastNameProp) && !string.IsNullOrEmpty(firstNameProp))
                n = 5;
            if (!string.IsNullOrEmpty(lastNameProp) && !string.IsNullOrEmpty(firstNameProp) && !string.IsNullOrEmpty(departmentProp))
                n = 6;
            if (!string.IsNullOrEmpty(lastNameProp) && string.IsNullOrEmpty(firstNameProp) && string.IsNullOrEmpty(departmentProp))
                n = 7;
            if (!string.IsNullOrEmpty(firstNameProp) && string.IsNullOrEmpty(lastNameProp) && string.IsNullOrEmpty(departmentProp))
                n = 8;

            switch (n)
            {
                case 1:
                    employees = EmployeeDataAccess.SortEmployees(EmployeeDataAccess.SearchEmployees("FirstName = " + "\""
                        + firstNameProp + "\""
                        + " AND Department = " + "\"" + departmentProp + "\""), "LastName");
                    break;
                case 2:
                    employees = EmployeeDataAccess.SortEmployees(EmployeeDataAccess.SearchEmployees("Department = " + "\""
                        + departmentProp + "\""), "LastName");
                    break;
                case 3:
                    employees = EmployeeDataAccess.SortEmployees(EmployeeDataAccess.GetAllEmployees(), "LastName");
                    break;
                case 4:
                    employees = EmployeeDataAccess.SortEmployees(EmployeeDataAccess.SearchEmployees("LastName = " + "\"" + lastNameProp + "\""
                        + " AND Department = " + "\"" + departmentProp + "\""), "LastName");
                    break;
                case 5:
                    employees = EmployeeDataAccess.SortEmployees(EmployeeDataAccess.SearchEmployees("LastName = " + "\"" + lastNameProp + "\""
                        + " AND FirstName = " + "\"" + firstNameProp + "\""), "LastName");
                    break;
                case 6:
                    employees = EmployeeDataAccess.SortEmployees(EmployeeDataAccess.SearchEmployees("LastName = " + "\"" + lastNameProp + "\""
                        + " AND FirstName = " + "\"" + firstNameProp + "\""
                        + " AND Department = " + "\"" + departmentProp + "\""), "LastName");
                    break;
                case 7:
                    employees = EmployeeDataAccess.SortEmployees(EmployeeDataAccess.SearchEmployees("LastName = "
                        + "\"" + lastNameProp + "\""), "LastName");
                    break;
                case 8:
                    employees = EmployeeDataAccess.SortEmployees(EmployeeDataAccess.SearchEmployees("FirstName = "
                        + "\"" + firstNameProp + "\""), "LastName");
                    break;
                default:
                    employees = EmployeeDataAccess.SortEmployees(EmployeeDataAccess.GetAllEmployees(), "LastName");
                    break;
            }
            
            DataTable dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[6] { new DataColumn("EmployeeID"), new DataColumn("LastName"),
                new DataColumn("FirstName"), new DataColumn("Department"),
                new DataColumn("Title"), new DataColumn("Extension")});

            foreach (var employee in employees)
            {
                DataRow dr = dt.NewRow();
                dr["EmployeeID"] = employee.EmployeeID;
                dr["FirstName"] = employee.FirstName;
                dr["LastName"] = employee.LastName;
                dr["Title"] = employee.Title;
                dr["Department"] = employee.Department;
                dr["Extension"] = employee.Extension;
                dt.Rows.Add(dr);
            }            
            SearchResultGridView.DataSource = dt;
            SearchResultGridView.DataBind();


        }
    }
}
