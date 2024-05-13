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

    protected void TextBox1_TextChanged1(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance o the clsStock
        clsStock AStock = new clsStock();
        //capture the car id
        AStock.CarID = Convert.ToInt16(txtCarID.Text);
        //capture the stock total
        AStock.StockTotal = Convert.ToInt16(txtStockTotal.Text);
        //capture the car model
        AStock.CarModel = txtCarModel.Text;
        //capture the car colour
        AStock.CarColour = txtCarColour.Text;
        //capture the car brand
        AStock.CarBrand = txtCarBrand.Text;
        //capture the stock arrive date
        AStock.StockArriveDate = Convert.ToDateTime(txtStockArriveDate.Text);
        //capture stock available check box
        AStock.StockAvailable = chkStockAvailable.Checked;
        //store the address in the session object
        Session["AStock"] = AStock;
        //navigate to the view page
        Response.Redirect("StockViewer.aspx");
    }



    //BtnFind
    protected void Button1_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsStock AStock = new clsStock();
        //create a variable to store the primary key
        Int32 CarID;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CarID = Convert.ToInt32(txtCarID.Text);
        //find the record
        Found = AStock.Find(CarID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtStockTotal.Text = AStock.StockTotal.ToString();
            txtCarModel.Text = AStock.CarModel;
            txtCarColour.Text = AStock.CarColour;
            txtCarBrand.Text = AStock.CarBrand;
            txtStockArriveDate.Text = AStock.StockArriveDate.ToString();
            chkStockAvailable.Checked = AStock.StockAvailable;
        }
    }
}