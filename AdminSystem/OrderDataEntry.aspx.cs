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

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }
}