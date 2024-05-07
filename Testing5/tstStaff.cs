using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //test to see that it exists
            Assert.IsNotNull(Staff);
        }

        public void isAdminOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create some test data to assign to the property
            Boolean TestData = true;

            //assign the data to the property
            Staff.IsAdmin = TestData;

            //test to see that the two value are equal
            Assert.AreEqual(TestData, Staff.IsAdmin);
        }

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
    }
}
