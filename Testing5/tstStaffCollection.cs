using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testing5
{
    
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }
        [TestMethod]
        public void StaffListOk() 
        {
            //create an instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property, in this case a list
            List<clsStaff> TestList = new List<clsStaff>();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set the properties
            TestItem.StaffId = 1;
            TestItem.StaffName = "bob";
            TestItem.JobTitle = "admin";
            TestItem.StaffEmail = "bob@work.com";
            TestItem.StaffAddress = "1 main street";
            TestItem.DateJoined = DateTime.Now;
            TestItem.IsAdmin = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);

        }
        [TestMethod]
        public void ThisStaffMemberPropertyOK()
        {
            //create an instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestItem = new clsStaff();
            //set the properties
            TestItem.StaffId = 1;
            TestItem.StaffName = "bob";
            TestItem.JobTitle = "admin";
            TestItem.StaffEmail = "bob@work.com";
            TestItem.StaffAddress = "1 main street";
            TestItem.DateJoined = DateTime.Now;
            TestItem.IsAdmin = true;
            //assign the data to the property
            AllStaff.ThisStaffMember = TestItem;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaffMember, TestItem);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property, in this case a list
            List<clsStaff> TestList = new List<clsStaff>();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set the properties
            TestItem.StaffId = 1;
            TestItem.StaffName = "bob";
            TestItem.JobTitle = "admin";
            TestItem.StaffEmail = "bob@work.com";
            TestItem.StaffAddress = "1 main street";
            TestItem.DateJoined = DateTime.Now;
            TestItem.IsAdmin = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);  
        }
    }
}
