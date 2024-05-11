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
        String FullName = txtFullName.Text;
        //capture the Customer Email
        String CustomerEmail = txtCustomerEmail.Text;
        //capture the Customer Phone Number
        String CustomerPhone = txtCustomerPhone.Text;
        //capture the Customer Address
        String Address = txtAddress.Text;
        //capture the Registration Date
        String RegistrationDate = txtRegistrationDate.Text;    
        //Capture Email Opt In check box
        String EmailOptIn = chkEmailOptIn.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data 
        Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
        if (Error == "")
        {
            //capture the FullName
            AnCustomer.FullName = FullName;
            //capture the CustomerEmail
            AnCustomer.CustomerEmail = CustomerEmail;
            //capture the CustomerPhone
            AnCustomer.CustomerPhone = CustomerPhone;
            //capture the Address
            AnCustomer.Address = Address;
            //capture the RegistrationDate
            AnCustomer.RegistrationDate = Convert.ToDateTime(RegistrationDate);
            //store the Customer in the session object
            Session["AnCustomer"] = AnCustomer;
            //navigate to the view page
            Response.Redirect("CustomerViewer.aspx");

        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
 
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

    protected void chkEmailOptIn_CheckedChanged(object sender, EventArgs e)
    {

    }
}
