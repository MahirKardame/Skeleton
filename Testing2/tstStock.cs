using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            // Test to see that it exists
            Assert.IsNotNull(AStock);
        }
    }
}
