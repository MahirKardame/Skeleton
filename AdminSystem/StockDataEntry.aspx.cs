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
        //capture the stock total
        string StockTotal = txtStockTotal.Text;
        //capture the car model
        string CarModel = txtCarModel.Text;
        //capture the car colour
        string CarColour = txtCarModel.Text;
        //capture the car brand
        string CarBrand = txtCarBrand.Text;
        //capture the stock arrive date
        string StockArriveDate = txtStockArriveDate.Text;
        //capture stock available check box
        string StockAvailable = chkStockAvailable.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AStock.Valid(StockTotal, CarModel, CarColour, CarColour, StockArriveDate);
        if (Error == "")
        {
            //capture the Stock total
            AStock.StockTotal = Convert.ToInt32(StockTotal);
            //capture the car model
            AStock.CarModel = CarModel;
            //capture the car colour
            AStock.CarColour = CarColour;
            //capture the car bramd
            AStock.CarBrand = CarBrand;
            //capture the Stock arrive date
            AStock.StockArriveDate = Convert.ToDateTime(StockArriveDate);
            //store the address in the session object
            Session["AStock"] = AStock;
            //navigate to the view page
            Response.Redirect("StockViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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