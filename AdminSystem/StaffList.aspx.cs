using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStaffMembers();
        }
    }
    void DisplayStaffMembers()
    {
        //create an instance of the staff collection
        clsStaffCollection StaffMembers = new clsStaffCollection();
        //set the data source to the list of staff members in the collection
        lstStafflist.DataSource = StaffMembers.StaffList;
        //set the name of the primary key
        lstStafflist.DataValueField = "StaffId";
        //set the data field to display
        lstStafflist.DataTextField = "staffName";
        //bind the data to the list
        lstStafflist.DataBind();
    }



    protected void addBtn_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffId"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key of  the record to be edited
        Int32 StaffId;
        //if a record has been selected from the list
        if(lstStafflist.SelectedIndex != -1)
        {
            //get the primary key of the record to edit
            StaffId = Convert.ToInt32(lstStafflist.SelectedValue);
            //store the data in the session object
            Session["StaffId"] = StaffId;
            //redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key of  the record to be edited
        Int32 StaffId;
        //if a record has been selected from the list
        if (lstStafflist.SelectedIndex != -1)
        {
            //get the primary key of the record to edit
            StaffId = Convert.ToInt32(lstStafflist.SelectedValue);
            //store the data in the session object
            Session["StaffId"] = StaffId;
            //redirect to the delete page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }
}