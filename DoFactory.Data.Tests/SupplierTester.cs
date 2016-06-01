using System.Linq;
using DoFactory.Data.Repositories;
using NUnit.Framework;

namespace DoFactory.Data.Tests
{
    [TestFixture]
    public class SupplierTester
    {
        [Test]
        public void ShouldGetSupplier()
        {
            var repo = new SupplierRepository();
            var supplier = repo.GetSupplier(1);

            Assert.AreEqual("Exotic Liquids", supplier.CompanyName);
        }

        [Test]
        public void ShouldGetAllSuppliers()
        {
            var repo = new SupplierRepository();
            var suppliers = repo.GetAllSuppliers();

            Assert.IsNotEmpty(suppliers);
            Assert.AreEqual("Charlotte Cooper", suppliers.First().ContactName);
        }
    }
}