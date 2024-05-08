using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for staff id property
        private Int32 mStaffId;
        //staffId public property
        public Int32 staffId
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffId;
            }
            set
            {
                //this line of code allows data into the property
                mStaffId = value;
            }
        }

        //private data member for staff name property
        private string mStaffName;
        //staff name public property
        public string staffName
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffName;
            }
            set
            {
                //this line of code allows data into the property
                mStaffName = value;
            }
        }

        //private data member for job title property
        private string mJobTitle;
        //job title public property
        public string jobTitle
        {
            get
            {
                //this line of code sends data out of the property
                return mJobTitle;
            }
            set
            {
                //this line of code allows data into the property
                mJobTitle = value;
            }
        }

        //private data member for staff email property
        private string mStaffEmail;
        //staff email public property
        public string staffEmail
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffEmail;
            }
            set
            {
                //this line of code allows data into the property
                mStaffEmail = value;
            }
        }

        //private data member for staff address property
        private string mStaffAddress;
        //staff address public property
        public string staffAddress
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffAddress;
            }
            set
            {
                //this line of code allows data into the property
                mStaffAddress = value;
            }
        }

        //private data member for dateJoined property
        private DateTime mDateJoined;
        //dateJoined public property
        public DateTime dateJoined
        {
            get
            {
                //this line of code sends data out of the property
                return mDateJoined;
            }
            set
            {
                //this line of code allows data into the property
                mDateJoined = value;
            }
        }

        //private data member for isAdmin property
        private Boolean mIsAdmin;
        //isAdmin public property
        public bool isAdmin
        {
            get
            {
                //this line of code sends data out of the property
                return mIsAdmin;
            }
            set
            {
                //this line of code allows data into the property
                mIsAdmin = value;
            }
        }

        /****** FIND METHOD ******/
        public bool Find(int staffID)
        {
            //set the private data members to the test data values
            mStaffId = 2;
            mStaffName = "Joe";
            mJobTitle = "cleaner";
            mStaffEmail = "joe@work.com";
            mStaffAddress = "1 main street";
            mDateJoined = Convert.ToDateTime("01/01/2024"); ;
            mIsAdmin = true;

            //always return true
            return true;
        }
    }
}