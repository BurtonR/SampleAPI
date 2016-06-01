using System.Linq;
using DoFactory.Data.Repositories;
using NUnit.Framework;

namespace DoFactory.Data.Tests
{
    [TestFixture]
    public class CustomerTester
    {
        [Test]
        public void ShouldGetCustomer()
        {
            var repo = new CustomerRepository();
            var customer = repo.GetCustomer(4);

            Assert.AreEqual("Thomas", customer.FirstName);
            Assert.AreEqual("Hardy", customer.LastName);
        }

        [Test]
        public void ShouldGetAllCustomers()
        {
            var repo = new CustomerRepository();
            var orders = repo.GetAllCustomers().ToList();

            Assert.IsNotEmpty(orders);
            Assert.AreEqual("Anders", orders.First().LastName);
        }
    }
}