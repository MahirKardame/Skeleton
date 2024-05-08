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

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();


        //capture the Fullname 
        AnCustomer.FullName = txtFullName.Text;
        //capture the Customer Email
        AnCustomer.CustomerEmail = txtCustomerEmail.Text;
        //capture the Customer Phone Number
        AnCustomer.CustomerPhone = txtCustomerPhone.Text;
        //capture the Customer Address
        AnCustomer.Address = txtAddress.Text;
        //capture the Registration Date
        AnCustomer.RegistrationDate = Convert.ToDateTime(DateTime.Now);    
        //Capture Email Opt In check box
        AnCustomer.EmailOptIn = chkEmailOptIn.Checked;


        //store the Customer in the session object
        Session["anCustomer"] = AnCustomer;
        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");

        
    }

}
