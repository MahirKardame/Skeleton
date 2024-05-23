﻿using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //private member data for thisStock
        clsStock mThisStock = new clsStock();
        public List<clsStock> StockList
        {
            get
            {
                //return the private data
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mStockList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsStock ThisStock
        {
            get
            {
                //return the private data
                return mThisStock;
            }
            set
            {
                //set the private data
                mThisStock = value;
            }
        }

        

        //constructor for the class
        public clsStockCollection()
        {

            

            //variable for the index
            Int32 Index = 0;
            //vairiable to store the data connect
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //get the count of records to process
            RecordCount = DB.Count;
            //while there ae records to process
            while (Index < RecordCount)
            {
                //create a blank stock
                clsStock AStock = new clsStock();
                //read in the fields for the current record
                AStock.CarID = Convert.ToInt32(DB.DataTable.Rows[Index]["CarID"]);
                AStock.StockTotal = Convert.ToInt32(DB.DataTable.Rows[Index]["StockTotal"]);
                AStock.CarModel = Convert.ToString(DB.DataTable.Rows[Index]["CarModel"]);
                AStock.CarColour = Convert.ToString(DB.DataTable.Rows[Index]["CarColour"]);
                AStock.CarBrand = Convert.ToString(DB.DataTable.Rows[Index]["CarBrand"]);
                AStock.StockArriveDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StockArriveDate"]);
                AStock.StockAvailable = Convert.ToBoolean(DB.DataTable.Rows[Index]["StockAvailable"]);
                //add the record to the private data member
                mStockList.Add(AStock);
                //point at the next record
                Index++;
            }


        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StockTotal", mThisStock.StockTotal);
            DB.AddParameter("@CarModel", mThisStock.CarModel);
            DB.AddParameter("@CarColour", mThisStock.CarColour);
            DB.AddParameter("@CarBrand", mThisStock.CarBrand);
            DB.AddParameter("@StockAvailable", mThisStock.StockAvailable);
            DB.AddParameter("@StockArriveDate", mThisStock.StockArriveDate);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters fpr the new stored procedure
            DB.AddParameter("@CarID", mThisStock.CarID);
            DB.AddParameter("@StockTotal", mThisStock.StockTotal);
            DB.AddParameter("@CarModel", mThisStock.CarModel);
            DB.AddParameter("@CarColour", mThisStock.CarColour);
            DB.AddParameter("@CarBrand", mThisStock.CarBrand);
            DB.AddParameter("@StockAvailable", mThisStock.StockAvailable);
            DB.AddParameter("@StockArriveDate", mThisStock.StockArriveDate);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Update");
        }
    }
}