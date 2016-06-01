using System.Linq;
using DoFactory.Data.Repositories;
using NUnit.Framework;

namespace DoFactory.Data.Tests
{
    [TestFixture]
    public class OrderItemTester
    {
        [Test]
        public void ShouldGetOrderItem()
        {
            var repo = new OrderItemRepository();
            var orderItem = repo.GetOrderItem(4);

            Assert.AreEqual(18.6, orderItem.UnitPrice);
            Assert.AreEqual(9, orderItem.Quantity);
        }

        [Test]
        public void ShouldGetAllOrderItems()
        {
            var repo = new OrderItemRepository();
            var orderItems = repo.GetAllOrderItems().ToList();

            Assert.IsNotEmpty(orderItems);
            Assert.AreEqual(14, orderItems.First().UnitPrice);
            Assert.AreEqual(12, orderItems.First().Quantity);
        }

        [Test]
        public void ShouldGetOrderItemsByOrder()
        {
            var repo = new OrderItemRepository();
            var orderItems = repo.GetOrderItemsByOrder(3).ToList();

            Assert.IsNotEmpty(orderItems);
            Assert.AreEqual(3, orderItems.Count());
        }

        [Test]
        public void ShouldGetOrderItemsByProduct()
        {
            var repo = new OrderItemRepository();
            var orderItems = repo.GetOrderItemsByProduct(7);

            Assert.IsNotEmpty(orderItems);
            //Can't test count because there may be more orders of this product
        }
    }
}