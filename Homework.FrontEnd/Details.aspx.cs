using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Homework.BackEnd;

namespace Homework.FrontEnd
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                var employee = EmployeeDataAccess.GetEmployeeByID(int.Parse(Request.QueryString["employeeId"]));
                EmployeeID.Text = employee.EmployeeID.ToString();
                LastName.Text = employee.LastName;
                FirstName.Text = employee.FirstName;
                Extension.Text = employee.Extension.ToString();
                EmployeePicture.ImageUrl = "Images/" + employee.EmployeeID.ToString() + ".jpg";
                Error.Visible = false;
            }
            catch (Exception)
            {
                Error.Text = Request.QueryString["employeeId"] + " is an invalid parameter";
                EmployeeID.Visible = false;
                LastName.Visible = false;
                FirstName.Visible = false;
                Extension.Visible = false;
                EmployeePicture.Visible = false;
            }

        }
    }
}