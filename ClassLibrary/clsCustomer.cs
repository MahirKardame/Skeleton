using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the address id property
        private Int32 mCustomerID;

        public int CustomerID
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerID;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerID = value;
            }
        }

        //private data member for the EmailOptIn property
        private Boolean mEmailOptIn;
        //active public property
        public bool EmailOptIn
        {
            get
            {
                //this line of code sends data out of the property
                return mEmailOptIn;
            }
            set
            {
                //this line of code allows data into the property
                mEmailOptIn = value;
            }
        }

        //private data member for the registration date property
        private DateTime mRegistrationDate;
        //date added public property
        public DateTime RegistrationDate
        {
            get
            {
                //this line of code sends data out of the property
                return mRegistrationDate;
            }
            set
            {
                mRegistrationDate = value;
            }
        }
        
        //private data member for the street property
        private String mFullName;
        //street public property 
        public String FullName
        {
            get
            {
                //this line of code sends data out of the property
                return mFullName;
            }
            set
            {
                //this line of code allows data into the property
                mFullName = value;
            }
        }

        //private data member for the street property
        private String mCustomerEmail;
        //street public property 
        public String CustomerEmail
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerEmail;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerEmail = value;
            }
        }

        //private data member for the street property
        private String mCustomerPhone;
        //street public property 
        public String CustomerPhone
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerPhone;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerPhone = value;
            }
        }

        //private data member for the street property
        private String mAddress;
        //street public property 
        public String Address
        {
            get
            {
                //this line of code sends data out of the property
                return mAddress;
            }
            set
            {
                //this line of code allows data into the property
                mAddress = value;
            }
        }


       // **** Find Method ***** //
       public bool Find (int CustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mEmailOptIn = Convert.ToBoolean(DB.DataTable.Rows[0]["EmailOptIn"]);
                mRegistrationDate = Convert.ToDateTime(DB.DataTable.Rows[0]["RegistrationDate"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerPhone = Convert.ToString(DB.DataTable.Rows[0]["CustomerPhone"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }

        
    }
}
