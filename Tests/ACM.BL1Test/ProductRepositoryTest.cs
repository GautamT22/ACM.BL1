using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


using ACM.BL1;

namespace ACM.BL1Test
{
    [TestClass()]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetriveValid()

        {

            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 15.96M,
                ProductDescription = "Assorted Size Set of 4 Bright Yelow Mini Sunflowers",
                ProductName = "Sunflowers"

            };

            var actual = productRepository.Retrieve(2);

            //Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);


        }

        [TestMethod]
        public void SaveTestValid()

        {

            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                CurrentPrice = 15.96M,
                ProductDescription = "Assorted Size Set of 4 Bright Yelow Mini Sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true

            };

            var actual = productRepository.Save(updateProduct);

            //Assert.AreEqual(expected, actual);
            Assert.AreEqual(true, actual);

        }
        [TestMethod]
        public void SaveTestMissingPrice()

        {

            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "Assorted Size Set of 4 Bright Yelow Mini Sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true

            };

            var actual = productRepository.Save(updateProduct);

            //Assert.AreEqual(expected, actual);
            Assert.AreEqual(false, actual);

        }

    }
}