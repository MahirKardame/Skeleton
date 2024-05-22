using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e) 
    {
        // If this is the first time the page is displayed.
        if (IsPostBack == false)
        {
            // Update the list box.
            DisplayOrders();
        }
    }

    void DisplayOrders()
    { 
        // Create an instance of the Address collection.
        clsOrderCollection Orders = new clsOrderCollection();
        // Set the data source to list of addresses in the collection.
        lstOrderList.DataSource = Orders.OrderList;
        // Set the name of the primary key.
        lstOrderList.DataValueField = "OrderID";
        // Set the data field to display.
        lstOrderList.DataTextField = "CustomerNote";
        // Bind the data to the list.
        lstOrderList.DataBind();
    }


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // Variable to store the primary key value of the record to be edited.
        Int32 OrderID;
        // If a record has been selected from the list.
        if (lstOrderList.SelectedIndex != -1)
        {
            // Get the Primary Key value of the record to edit.
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            // Store the data in the session object.
            Session["OrderID"] = OrderID;
            // Redirect to the edit page.
            Response.Redirect("OrderDataEntry.aspx");
        }
        else // If no record has been selected.
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderID"] = -1;
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // Variable to store the primary key value of the record to be deleted.
        Int32 OrderID;
        // If a record has been selected from the list.
        if (lstOrderList.SelectedIndex != -1)
        {
            // Get the Primary Key value of the record to delete.
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            // Store the data in the session object.
            Session["OrderID"] = OrderID;
            // Redirect to the delete page.
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else // If no record has been selected.
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }
}