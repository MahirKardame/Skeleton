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


    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer AnCustomer = new clsCustomer();
        //create a variable to store the primary key
        Int32 CustomerID;
        //create a variable to store the primary key
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //Find the record
        Found = AnCustomer.Find(CustomerID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtAddress.Text = AnCustomer.Address;
            txtCustomerPhone.Text = AnCustomer.CustomerPhone;
            txtCustomerEmail.Text = AnCustomer.CustomerEmail;
            txtFullName.Text = AnCustomer.FullName;
            txtRegistrationDate.Text = AnCustomer.RegistrationDate.ToString();
            chkEmailOptIn.Checked = AnCustomer.EmailOptIn;

        }
        



    }
}
