using ACME.BL;
using Newtonsoft.Json;
using System.Security.AccessControl;

namespace ACME.BLTest
{
    [TestClass]
    public class CustomerRepoTest
    {
        Customer expected = new Customer(1)
        {
            EmailAddress = "jim@gmail.com",
            FirstName = "jim",
            LastName = "dawg",
            AddressList = new List<Address>()
                {
                    new Address(1)
                    {
                        City = "Cebu",
                        PostalCode = 1,
                        Country = "Philippines"
                    },
                    new Address(1)
                    {
                        City = "LLC",
                        PostalCode = 6015,
                        Country = "Philippines"
                    },
                    new Address(1)
                    {
                        City = "Manila",
                        PostalCode = 2103,
                        Country = "Philippines"
                    }
                }
        };


     [TestMethod]
        public void isRetrieveCustomerWorking()
        {
            //Arrange
            var customerRepo = new CustomerRepo();
            var conv_expected = JsonConvert.SerializeObject(expected);
            

            //Act
            Customer actual = customerRepo.RetrieveCustomer(1);
            var conv_actual = JsonConvert.SerializeObject(actual);

            //Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(conv_expected, conv_actual);
        }

        [TestMethod]
        public void isRetrieveCustomerAddress() 
        {
            //Act
            var customerRepo = new CustomerRepo();
            var conv_expected = JsonConvert.SerializeObject(expected);



            //Arrange
            var actual = customerRepo.RetrieveCustomer(1);
            var conv_actual = JsonConvert.SerializeObject(actual);

            //Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(conv_expected, conv_actual);


        }

    }
}



