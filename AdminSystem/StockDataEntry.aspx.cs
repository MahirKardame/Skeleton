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
        AStock.StockTotal = Convert.ToInt16(txtTotalStock.Text);
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
}