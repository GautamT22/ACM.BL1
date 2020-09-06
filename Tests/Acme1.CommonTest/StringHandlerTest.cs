using System;
using Acme1.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme1.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";
            

            var actual = source.InsertSpaces();
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void InsertSpacesTestWithExistingSpaces()
        {
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";


            var actual = source.InsertSpaces();
            Assert.AreEqual(expected, actual);

        }
    }
}
