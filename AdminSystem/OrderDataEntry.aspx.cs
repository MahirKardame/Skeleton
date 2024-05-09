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

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        // Capture the Customer Note
        AnOrder.CustomerNote = txtCustomerNote.Text;
        // Store the note in the session object.
        Session["AnOrder"] = AnOrder;
        // Navigate to the view page
        Response.Redirect("OrderViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        // Create an instance of the Order class.
        clsOrder AnOrder = new clsOrder();
        // Create a variable to store the primary key.
        Int32 OrderID;
        // Create a variable to store the primary key.
        Boolean Found = false;
        // Get the key from user input.
        try
        {
            OrderID = Convert.ToInt32(txtOrderID.Text);
            // Find the record.
            Found = AnOrder.Find(OrderID);
            // If found.
            if (Found)
            {
                // Display the values of the properties in the form.
                chkPaid.Checked = AnOrder.IsPaid;
                txtDatePlaced.Text = AnOrder.DateOrderPlaced.ToString();
                txtDeliveryType.Text = AnOrder.DeliveryType;
                txtPrice.Text = AnOrder.OrderPrice.ToString();
                txtStaffNote.Text = AnOrder.StaffNote;
                txtCustomerNote.Text = AnOrder.CustomerNote;
            }
            else
            {
                lblError.Text = "Invalid OrderID!";
            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
        }
    }
}