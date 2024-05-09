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
        Staff.isAdmin = chkIsAdmin.Checked;
        //store the name in the session object
        Session["Staff"] = Staff;
        //navigate to the view page
        Response.Redirect("StaffViewer.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the staff class
        clsStaff Staff = new clsStaff();
        //create a variable to store the primary key
        Int32 staffId;
        //create a variable to store the result of the find method
        Boolean found = false;
        //get the primary key entered by the user
        staffId = Convert.ToInt32(txtStaffId.Text);
        //find the record
        found = Staff.Find(staffId);
        //if found
        if(found)
        {
            //display the properties in the form
            txtStaffName.Text = Staff.staffName;
            txtJobTitle.Text = Staff.jobTitle;
            txtStaffEmail.Text = Staff.staffEmail;
            txtStaffAddress.Text = Staff.staffAddress;
            txtDateJoined.Text = Staff.dateJoined.ToString();
            chkIsAdmin.Checked = Staff.isAdmin;

        }
    }
}