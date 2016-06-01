using System.Linq;
using DoFactory.Data.Repositories;
using NUnit.Framework;

namespace DoFactory.Data.Tests
{
    [TestFixture]
    public class ProductTester
    {
        [Test]
        public void ShouldGetProduct()
        {
            var thing = new ProductRepository();
            var result = thing.GetProduct(4);

            Assert.AreEqual("Chef Anton's Cajun Seasoning", result.ProductName);
        }

        [Test]
        public void ShouldGetAllProducts()
        {
            var repo = new ProductRepository();
            var result = repo.GetAllProducts();

            Assert.IsNotEmpty(result);
            Assert.AreEqual(result.First().ProductName, "Chai");
        }
    }
}
