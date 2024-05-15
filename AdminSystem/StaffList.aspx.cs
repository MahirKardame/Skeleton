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
}