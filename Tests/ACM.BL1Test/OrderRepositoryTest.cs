using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL1;

namespace ACM.BL1Test
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]

        public void RetriveOrderDisplayTest()

        {

            var orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))

            };


            var actual = orderRepository.Retrieve(10);

            //Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);


        }
            }
        }
    

