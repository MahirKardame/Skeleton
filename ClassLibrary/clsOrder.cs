using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool IsPaid { get; set; }
        public DateTime DateOrderPlaced { get; set; }
        public string DeliveryType { get; set; }
        public int OrderPrice { get; set; }
        public string StaffNote { get; set; }
        public string CustomerNote { get; set; }
        public int OrderID { get; set; }
    }
}