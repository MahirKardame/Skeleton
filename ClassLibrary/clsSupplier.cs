using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        public bool Available { get; set; }
        public DateTime LastOrderDate { get; set; }
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}