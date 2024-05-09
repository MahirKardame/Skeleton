using System;

namespace ClassLibrary
{
    public class clsSupplier
    {


        //private data member for the supplier id
        private Int32 mSupplierId;
        //suplierId public
        public Int32 SupplierId
        {
            get
            {
                //this line of code sends data out of the supplier
                return mSupplierId;
            }
            set
            {
                //this line of code allows data into the supplier
                mSupplierId = value;
            }

        }
        


        //private data member for the date added to supplier
        private DateTime mLastOrderDate;
        //date added public property
        public DateTime LastOrderDate
        {
            get
            {
                //this line of code sends data out of the supplier
                return mLastOrderDate;
            }
            set
            {
                //this line of code allows data into the supplier
                mLastOrderDate = value;
            }
        }

        //private data member for the supplier Name
        private string mSupplierName;
        //street public property
        public string SupplierName
        {
            get
            {
                //this line of code sends data out of the supplier
                return mSupplierName;
            }
            set
            {
                //this line of code allows data into the supplier
                mSupplierName = value;
            }
        }


        //private data member for the supplier Email
        private string mSupplierEmail;
        //town public property
        public string SupplierEmail
        {
            get
            {
                //this line of code sends data out of the supplier
                return mSupplierEmail;
            }
            set
            {
                //this line of code allows data into the supplier
                mSupplierEmail = value;
            }
        }



        //private data member for the supplier phone number
        private string mPhoneNumber;
        //town public property
        public string PhoneNumber
        {
            get
            {
                //this line of code sends data out of the supplier
                return mPhoneNumber;
            }
            set
            {
                //this line of code allows data into the supplier
                mPhoneNumber = value;
            }
        }


        //private data member for the supplier phone number
        private string mAddress;
        //town public property
        public string Address
        {
            get
            {
                //this line of code sends data out of the supplier
                return mAddress;
            }
            set
            {
                //this line of code allows data into the supplier
                mAddress = value;
            }
        }


        //private data member for the active property
        private Boolean mAvailable;
        //active public property
        public bool Available
        {
            get
            {
                //this line of code sends data out of the property
                return mAvailable;
            }
            set
            {
                //this line of code allows data into the property
                mAvailable = value;
            }
        }


        public bool Find(int supplierId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the supplier id to search for
            DB.AddParameter("@SupplierId", supplierId);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterBySupplierId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data member
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);
                mLastOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["LastOrderDate"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mSupplierEmail = Convert.ToString(DB.DataTable.Rows[0]["SupplierEmail"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                //always return ture
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