using System;
using System.Collections.Generic;
using System.Data;
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
        //create a new instance of clsSupplier
        clsSupplier AnSupplier = new clsSupplier();
        //capture the All data
        AnSupplier.SupplierId = Convert.ToInt32(txtSupplierId.Text);
        AnSupplier.Name = txtName.Text;
        AnSupplier.Email = txtEmail.Text;
        AnSupplier.PhoneNumber = txtPhoneNumber.Text;
        AnSupplier.Address = txtAddress.Text;
        AnSupplier.LastOrderDate = Convert.ToDateTime(DateTime.Now);
        AnSupplier.Available = chkAvailable.Checked;
        //store the Name in a the session object
        Session["AnSupplier"] = AnSupplier;
        //navigate to the view page
        Response.Redirect("SupplierViewer.aspx");
    }


    protected void txtSupplierId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtEmail_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtPhoneNumber_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtAddress_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtLastOrderDate_TextChanged(object sender, EventArgs e)
    {

    }

    protected void chkAvailable_CheckedChanged(object sender, EventArgs e)
    {

    }
}