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
        Staff.StaffId = Convert.ToInt32(txtStaffId.Text);
        //capture the staffName
        Staff.StaffName = txtStaffName.Text;
        //capture the job title
        Staff.JobTitle = txtJobTitle.Text;
        //capture the staff email
        Staff.StaffEmail = txtStaffEmail.Text;
        //capture the staff address
        Staff.StaffAddress = txtStaffAddress.Text;
        //capture the date joined
        Staff.DateJoined = Convert.ToDateTime(txtDateJoined.Text);
        //capture isAdmin checkbox
        Staff.IsAdmin = chkIsAdmin.Checked;
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
            txtStaffName.Text = Staff.StaffName;
            txtJobTitle.Text = Staff.JobTitle;
            txtStaffEmail.Text = Staff.StaffEmail;
            txtStaffAddress.Text = Staff.StaffAddress;
            txtDateJoined.Text = Staff.DateJoined.ToString();
            chkIsAdmin.Checked = Staff.IsAdmin;

        }
    }
}