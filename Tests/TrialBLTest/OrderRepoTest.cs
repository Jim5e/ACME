using ACME.BL;
using Newtonsoft.Json;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ACME.BLTest;

[TestClass]
public class OrderRepoTest
{
    [TestMethod]
    public void isRetrieveOrderWorking()
    {
        //Arrange
        var OrderRepo = new OrderRepo();
        var dateOnly = DateOnly.FromDateTime(DateTime.Now);
        var expected = new Order(1)
        {
            OrderDate = dateOnly,
            ShippingAddress = "LAPU LAPU",
            OrderItems = null
        };

        var conv_expected = JsonConvert.SerializeObject(expected);


        //Act
        var actual = OrderRepo.RetrieveOrder(1);
        var conv_actual = JsonConvert.SerializeObject(actual);

        //Assert
        Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(conv_expected, conv_actual);
    }
}
