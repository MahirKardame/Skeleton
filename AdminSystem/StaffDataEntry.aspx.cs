using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of the staff class
        clsStaff Staff = new clsStaff();
        //capture the staffId
        Staff.staffId = Convert.ToInt32(txtStaffId.Text);
        //capture the staffName
        Staff.staffName = txtStaffName.Text;
        //capture the job title
        Staff.jobTitle = txtJobTitle.Text;
        //capture the staff email
        Staff.staffEmail = txtStaffEmail.Text;
        //capture the staff address
        Staff.staffAddress = txtStaffAddress.Text;
        //capture the date joined
        Staff.dateJoined = Convert.ToDateTime(txtDateJoined.Text);
        //capture isAdmin checkbox
        Staff.IsAdmin = chkIsAdmin.Checked;
        //store the name in the session object
        Session["Staff"] = Staff;
        //navigate to the view page
        Response.Redirect("StaffViewer.aspx");
    }
}