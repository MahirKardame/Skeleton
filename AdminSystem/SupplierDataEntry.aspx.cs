using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
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
        AnSupplier.SupplierName = txtSupplierName.Text;
        AnSupplier.SupplierEmail = txtSupplierEmail.Text;
        AnSupplier.PhoneNumber = txtPhoneNumber.Text;
        AnSupplier.Address = txtAddress.Text;
        AnSupplier.LastOrderDate = Convert.ToDateTime(DateTime.Now);
        AnSupplier.Available = chkAvailable.Checked;
        //store the Name in a the session object
        Session["AnSupplier"] = AnSupplier;
        //navigate to the view page
        Response.Redirect("SupplierViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the supplier class
        clsSupplier AnSupplier = new clsSupplier();
        //create a variable to store the primary key
        Int32 SupplierId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        SupplierId = Convert.ToInt32(txtSupplierId.Text);
        //find the record
        Found = AnSupplier.Find(SupplierId);
        //if found
        if (Found == true)
        {
            //display the values of the supplier in the form
            txtSupplierName.Text = AnSupplier.SupplierName;
            txtSupplierEmail.Text = AnSupplier.SupplierEmail;
            txtPhoneNumber.Text = AnSupplier.PhoneNumber;
            txtAddress.Text = AnSupplier.Address;
            txtLastOrderDate.Text = AnSupplier.LastOrderDate.ToString();
            chkAvailable.Checked = AnSupplier.Available;
        }
    }
}