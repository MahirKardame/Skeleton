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
        //capture the staffName
        string StaffName = txtStaffName.Text;
        //capture the job title
        string JobTitle = txtJobTitle.Text;
        //capture the staff email
        string StaffEmail = txtStaffEmail.Text;
        //capture the staff address
        string StaffAddress = txtStaffAddress.Text;
        //capture the date joined
        string DateJoined = txtDateJoined.Text;
        //capture isAdmin checkbox
        bool IsAdmin = chkIsAdmin.Checked;
        //validate the data
        string Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
        if(Error == "")
        {
            
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

            //create a new instance of the StaffCollection
            clsStaffCollection StaffList = new clsStaffCollection();
            //set the ThisStaffMember property
            StaffList.ThisStaffMember = Staff;
            //add the new record
            StaffList.Add();
            //redirect back to the list page
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            //display the error  message
            lblError.Text = Error;
        }


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