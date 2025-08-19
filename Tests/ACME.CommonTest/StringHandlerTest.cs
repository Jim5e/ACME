using ACME.Common;

namespace ACME.CommonTest
{
    [TestClass]
    public sealed class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacestTestValid()
        {
            //act
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            //Act
            var actual = source.InsertSpaces();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacestTestExistingSpaces()
        {
            //act
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            //Act
            var actual = source.InsertSpaces();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
