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

}