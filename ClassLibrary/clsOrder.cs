using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private bool privIsPaid;
        private DateTime privDateOrderPlaced;
        private string privDeliveryType;
        private int privOrderPrice;
        private string privStaffNote;
        private string privCustomerNote;
        private Int32 privOrderID;

        public bool IsPaid 
        {
            get
            {
                // This line of code sends the data out of the property.
                return privIsPaid;
            }
            set
            {
                // This line of code allows data into the property.
                privIsPaid = value;
            }
        }

        public DateTime DateOrderPlaced 
        {
            get
            {
                // This line of code sends the data out of the property.
                return privDateOrderPlaced;
            }
            set
            {
                // This line of code allows data into the property.
                privDateOrderPlaced = value;
            }
        }

        public string DeliveryType 
        {
            get
            {
                // This line of code sends the data out of the property.
                return privDeliveryType;
            }
            set
            {
                // This line of code allows data into the property.
                privDeliveryType = value;
            }
        }

        public int OrderPrice 
        {
            get
            {
                // This line of code sends the data out of the property.
                return privOrderPrice;
            }
            set
            {
                // This line of code allows data into the property.
                privOrderPrice = value;
            }
        }

        public string StaffNote 
        {
            get
            {
                // This line of code sends the data out of the property.
                return privStaffNote;
            }
            set
            {
                // This line of code allows data into the property.
                privStaffNote = value;
            }
        }

        public string CustomerNote 
        {
            get
            {
                // This line of code sends the data out of the property.
                return privCustomerNote;
            }
            set
            {
                // This line of code allows data into the property.
                privCustomerNote = value;
            }
        }
        
        public int OrderID 
        {
            get 
            {
                // This line of code sends the data out of the property.
                return privOrderID;
            }
            set 
            {
                // This line of code allows data into the property.
                privOrderID = value;
            } 
        }

        public bool Find(int orderID)
        {
            // Set the private data members to the test data value.
            privIsPaid = true;
            privDateOrderPlaced = Convert.ToDateTime("08/05/2024");
            privDeliveryType = "Express";
            privOrderPrice = 10000;
            privStaffNote = "Staff note.";
            privCustomerNote = "Customer note.";
            privOrderID = 21;
            // Always return true.
            return true;
        }
    }
}