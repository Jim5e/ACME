using System;
using ACME.BL;

namespace ACME.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "James";
            customer.LastName = "Clarit";
            string Expected = "Clarit, James";

            //Act
            string actual = customer.FullName;

            //Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(Expected, actual);

        }
    }
}
