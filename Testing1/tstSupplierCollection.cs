using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //test to see that is exists
            Assert.IsNotNull(AllSuppliers);
        }

        [TestMethod]
        public void SupplierListOK() 
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to supplier
            //in this case the data needed to be a list object
            List<clsSupplier> TestList = new List<clsSupplier>();
            //add an item to the list
            //create the item of the test data
            clsSupplier TestItem = new clsSupplier();
            //set its properties
            TestItem.SupplierId = 20;
            TestItem.SupplierName = "Audi";
            TestItem.SupplierEmail = "audi@gmail.com";
            TestItem.PhoneNumber = "01234567890";
            TestItem.Address = "Leicester LE4 0AH";
            TestItem.LastOrderDate = DateTime.Now;
            TestItem.Available = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the supplier
            AllSuppliers.SupplierList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.SupplierList, TestList);
        }

        [TestMethod]
        public void ThisSupplierOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to supplier
            clsSupplier TestSupplier = new clsSupplier();
            //set the properties of the test object
            TestSupplier.SupplierId = 20;
            TestSupplier.SupplierName = "Audi";
            TestSupplier.SupplierEmail = "audi@gmail.com";
            TestSupplier.PhoneNumber = "01234567890";
            TestSupplier.Address = "Leicester LE4 0AH";
            TestSupplier.LastOrderDate = DateTime.Now;
            TestSupplier.Available = true;
            //assign the data to the supplier
            AllSuppliers.ThisSupplier = TestSupplier;
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to supplier
            //in this case the data needs to be list of objects
            List<clsSupplier> TestList = new List<clsSupplier>();
            //add an item to the list
            //create the item of the test data
            clsSupplier TestItem = new clsSupplier();
            //set the properties of the test object
            TestItem.SupplierId = 20;
            TestItem.SupplierName = "Audi";
            TestItem.SupplierEmail = "audi@gmail.com";
            TestItem.PhoneNumber = "01234567890";
            TestItem.Address = "Leicester LE4 0AH";
            TestItem.LastOrderDate = DateTime.Now;
            TestItem.Available = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the supplier
            AllSuppliers.SupplierList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.Count, TestList.Count);
        }
    }
        
}
