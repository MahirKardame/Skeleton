using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff Staff = new clsStaff();
        //get the data from the session object
        Staff = (clsStaff)Session["Staff"];
        //display the staff id
        Response.Write(Staff.staffId);
        //display the staff name
        Response.Write(Staff.staffName);
        //display the job title
        Response.Write(Staff.jobTitle);
        //display the staff email
        Response.Write(Staff.staffEmail);
        //display the staff address
        Response.Write(Staff.staffAddress);
        //display the date Joined
        Response.Write(Staff.dateJoined);
        //display isAdmin
        Response.Write(Staff.IsAdmin);
    }
}