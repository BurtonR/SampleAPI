using System.Linq;
using DoFactory.Data.Repositories;
using NUnit.Framework;

namespace DoFactory.Data.Tests
{
    [TestFixture]
    public class OrderTester
    {
        [Test]
        public void ShouldGetOrder()
        {
            var repo = new OrderRepository();
            var order = repo.GetOrder(4);

            Assert.AreEqual(542381, order.OrderNumber);
            Assert.AreEqual(670.80, order.TotalAmount);
        }

        [Test]
        public void ShouldGetAllOders()
        {
            var repo = new OrderRepository();
            var orders = repo.GetAllOrders().ToList();

            Assert.IsNotEmpty(orders);
            Assert.AreEqual(542378, orders.First().OrderNumber);
        }
    }
}