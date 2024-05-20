using System;
using System.Collections.Generic;
using System.Net;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {

        //constructor for the class
        public clsCustomerCollection()
        {
            //variable  for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields for the current record
                //copy the data from the database to the private data members
                AnCustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnCustomer.EmailOptIn = Convert.ToBoolean(DB.DataTable.Rows[Index]["EmailOptIn"]);
                AnCustomer.RegistrationDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["RegistrationDate"]);
                //AnCustomer.EmailOptIn = DB.DataTable.Rows[Index]["EmailOptIn"] != DBNull.Value ? Convert.ToBoolean(DB.DataTable.Rows[Index]["EmailOptIn"]) : false;
               //AnCustomer.RegistrationDate = DB.DataTable.Rows[Index]["RegistrationDate"] != DBNull.Value
                //? Convert.ToDateTime(DB.DataTable.Rows[Index]["RegistrationDate"])
                //: DateTime.MinValue; // or any default value
                AnCustomer.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                AnCustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                AnCustomer.CustomerPhone = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPhone"]);
                AnCustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                //add the record to the private data member
                mCustomerList.Add(AnCustomer);
                //point at the next record
                Index++;
            }

        }

        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();

        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }

        //public property for the count
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data 
                mThisCustomer = value;
            }
        }



        public int Add()
        {
            //adds a record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramaters for the stored procedure
            DB.AddParameter("@fullName", mThisCustomer.FullName);
            DB.AddParameter("@customerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@customerPhone", mThisCustomer.CustomerPhone);
            DB.AddParameter("@address", mThisCustomer.Address);
            DB.AddParameter("@registrationDate", mThisCustomer.RegistrationDate);
            DB.AddParameter("@emailOptIn", mThisCustomer.EmailOptIn);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");

        }

        public void Update()
        {
            //update an existing record based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@fullName", mThisCustomer.FullName);
            DB.AddParameter("@customerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@customerPhone", mThisCustomer.CustomerPhone);
            DB.AddParameter("@address", mThisCustomer.Address);
            DB.AddParameter("@registrationDate", mThisCustomer.RegistrationDate);
            DB.AddParameter("@emailOptIn", mThisCustomer.EmailOptIn);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblCustomer_Update");
        }
    }
}