using ACME.BL;

namespace ACME.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        Customer customer = new Customer();
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            customer.FirstName = "James";
            customer.LastName = "Clarit";
            string Expected = "Clarit, James";

            //Act
            string actual = customer.FullName;

            //Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(Expected, actual);

        }

        [TestMethod]
        public void FullNameLastNameisEmpty()
        {
            //Arrange
            customer.FirstName = "James";
            customer.LastName = "";
            string Expected = "James";

            //Act
            string actual = customer.FullName;

            //Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(Expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameisEmpty()
        {
            //Arrange
            customer.FirstName = "";
            customer.LastName = "Clarit";
            string Expected = "Clarit";

            //Act
            string actual = customer.FullName;

            //Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(Expected, actual);
         }

        [TestMethod]
        public void FullNameBothisEmpty()
        {
            //Arrange
            customer.FirstName = "";
            customer.LastName = "";
            string Expected = "Please Input Fields.";

            //Act
            string actual = customer.FullName;

            //Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(Expected, actual);
        }

        [TestMethod]

        public void InstanceCount()
        {
            //Arrange
            Customer User1 = new Customer
            {
                FirstName = "James"
            };
            Customer.InstanceCount += 1;
            Customer User2 = new Customer
            {
                FirstName = "Terence"
            };
            Customer.InstanceCount += 1;
            Customer User3 = new Customer
            {
                FirstName = "Mom"
            };
            Customer.InstanceCount += 1;

            //Act
            int Expected = 3;
            int actual = Customer.InstanceCount;


            //Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(Expected, actual);

        }
    }
}