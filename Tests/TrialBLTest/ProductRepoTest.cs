using ACME.BL;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace ACME.BLTest;

[TestClass]
public class ProductRepoTest
{
    [TestMethod]
    public void isRetrieveProductWorking()
    {
        //Arrange
        var productRepo = new ProductRepo();
        var expected = new Product(1)
        {
            ProductName = "Chippy's",
            ProductDescription = "Its Chips.",
            CurrentPrice = 15.99D
        };
        var conv_expected = JsonConvert.SerializeObject(expected);

        //Act
        var actual = productRepo.RetrieveProduct(1);
        var conv_actual = JsonConvert.SerializeObject(actual);


        //Assert
        Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(conv_expected, conv_actual);

    }

   [TestMethod]
    public void isSaveWorkingTRUE()
    {
        //Arrange
        var productRepo = new ProductRepo();
        var expected = new Product(1)
        {
            ProductName = "Chippy's",
            ProductDescription = "Its Chips.",
            CurrentPrice = 99.99D,
            HasChanges = true
        };
        //Act
        var actual = productRepo.Save(expected);

        //Assert
        Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(true, actual);

    }

    [TestMethod]
    public void isSaveWorkingFALSE()
    {
        //Arrange
        var productRepo = new ProductRepo();
        var expected = new Product(1)
        {
            ProductName = "Chippy's",
            ProductDescription = "Its Chips.",
            CurrentPrice = null, //change to invalid value
            HasChanges = true
        };
        //Act
        var actual = productRepo.Save(expected);

        //Assert
        Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(false, actual);

    }
}
