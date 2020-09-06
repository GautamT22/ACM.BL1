using System;
using ACM.BL1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL1Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {

            //Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
           
            string expected = "Baggins,Bilbo";
            //Act
            string actual = "Baggins,Bilbo";


            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameFirstEmpty()
        {

            //Arrange
            Customer customer = new Customer
            {
                
                LastName = "Baggins"
            };

            string expected = "Baggins";
            //Act

            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastEmpty()
        {

            //Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                
            };

            string expected = "Bilbo";
            //Act
            string actual = customer.FullName;


            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StaticTest()
        {

            //Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Bilbo";
            Customer.InstanceCount += 1;


            //Act
            

            //Assert
            Assert.AreEqual(3,Customer.InstanceCount);
        }
        [TestMethod]
        public void ValidateValid()
        {
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "abc@cg.com"
            };
            var expected = true;

            var actual = customer.Validate();
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ValidateMissingLastName()
        {
            var customer = new Customer
            {
                
                EmailAddress = "abc@cg.com"
            };
            var expected = false;

            var actual = customer.Validate();
            Assert.AreEqual(expected, actual);

        }
    }
}
