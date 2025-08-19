using ACME.BL;
using ACME.Common;
using System.Net;

namespace ACME.CommonTest;

[TestClass]
public class LoggingServiceTest
{
    [TestMethod]
    public void WriteToFileTest()
    {
        //Arrange
        var itemstoLog = new List<ILoggable>();

        var customer = new Customer(1)
        {
            EmailAddress = "cooldawg@gmail.com",
            FirstName = "jim",
            LastName = "dawg"
        };
        var product = new Product(1)
        {
            ProductName = "Dicky's",
            ProductDescription = "Its Dick.",
            CurrentPrice = 15.99D
        };
        itemstoLog.Add(customer);
        itemstoLog.Add(product);

        //Act
        itemstoLog.WritetoFile();


        //Assert

    }
}
