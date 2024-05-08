using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstStaff
    {
        /******************INSTANCE OF THE CLASS TEST******************/

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //test to see that it exists
            Assert.IsNotNull(Staff);
        }
        /******************PROPERTY OK TESTS******************/

        [TestMethod]
        public void isAdminOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create some test data to assign to the property
            Boolean TestData = true;

            //assign the data to the property
            Staff.isAdmin = TestData;

            //test to see that the two value are equal
            Assert.AreEqual(TestData, Staff.isAdmin);
        }

        [TestMethod]
        public void dateJoinedOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;

            //assign the data to the property
            Staff.dateJoined = TestData;

            //test to see that the two value are equal
            Assert.AreEqual(TestData, Staff.dateJoined);

        }

        [TestMethod]
        public void staffIdOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create some test data to assign to the property
            Int32 TestData = 1;

            //assign the data to the property
            Staff.staffId = TestData;

            //test to see that the two value are equal
            Assert.AreEqual(TestData, Staff.staffId);

        }

        [TestMethod]
        public void staffNameOk()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create some test data to assign to the property
            string TestData = "test name";

            //assign the data to the property
            Staff.staffName = TestData;

            //test to see that the two value are equal
            Assert.AreEqual(TestData, Staff.staffName);

        }

        [TestMethod]
        public void jobTitleOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create some test data to assign to the property
            string TestData = "test job title";

            //assign the data to the property
            Staff.jobTitle = TestData;

            //test to see that the two value are equal
            Assert.AreEqual(TestData, Staff.jobTitle);

        }

        [TestMethod]
        public void staffEmailOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create some test data to assign to the property
            string TestData = "testEmail@email.com";

            //assign the data to the property
            Staff.staffEmail = TestData;

            //test to see that the two value are equal
            Assert.AreEqual(TestData, Staff.staffEmail);

        }

        [TestMethod]
        public void staffAddressOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create some test data to assign to the property
            string TestData = "1 main street";

            //assign the data to the property
            Staff.staffAddress = TestData;

            //test to see that the two value are equal
            Assert.AreEqual(TestData, Staff.staffAddress);

        }
        /******************FIND METHOD TEST******************/

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create a Boolean to store the result of the validation
            Boolean found = false;

            //create some test data to use with the method
            Int32 staffID = 2;

            //invoke the method
            found = Staff.Find(staffID);

            //test to see if the result is found
            Assert.IsTrue(found);
        }
        /******************PROPERTY DATA TESTS******************/

        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create a Boolean to store the result of the validation
            Boolean found = false;

            //create a Boolean to record if the data is OK (assumes it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 staffID = 2;

            //invoke the method
            found = Staff.Find(staffID);

            //check the staffId
            if (Staff.staffId != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create a Boolean to store the result of the validation
            Boolean found = false;

            //create a Boolean to record if the data is OK (assumes it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 staffID = 2;

            //invoke the method
            found = Staff.Find(staffID);

            //check the staffId
            if (Staff.staffName != "Joe")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestJobTitleFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create a Boolean to store the result of the validation
            Boolean found = false;

            //create a Boolean to record if the data is OK (assumes it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 staffID = 2;

            //invoke the method
            found = Staff.Find(staffID);

            //check the staffId
            if (Staff.jobTitle != "cleaner")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffEmailFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create a Boolean to store the result of the validation
            Boolean found = false;

            //create a Boolean to record if the data is OK (assumes it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 staffID = 2;

            //invoke the method
            found = Staff.Find(staffID);

            //check the staffId
            if (Staff.staffEmail != "joe@work.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffAddressFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create a Boolean to store the result of the validation
            Boolean found = false;

            //create a Boolean to record if the data is OK (assumes it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 staffID = 2;

            //invoke the method
            found = Staff.Find(staffID);

            //check the staffId
            if (Staff.staffAddress != "1 main street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateJoinedFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create a Boolean to store the result of the validation
            Boolean found = false;

            //create a Boolean to record if the data is OK (assumes it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 staffID = 2;

            //invoke the method
            found = Staff.Find(staffID);

            //check the staffId
            if (Staff.dateJoined != Convert.ToDateTime("01/01/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsAdminFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create a Boolean to store the result of the validation
            Boolean found = false;

            //create a Boolean to record if the data is OK (assumes it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 staffID = 2;

            //invoke the method
            found = Staff.Find(staffID);

            //check the staffId
            if (Staff.isAdmin != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
