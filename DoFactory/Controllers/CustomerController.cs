using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DoFactory.API.Models;
using DoFactory.Data.Repositories;
using Newtonsoft.Json;

namespace DoFactory.API.Controllers
{
    [RoutePrefix("api/Customer")]
    public class CustomerController : ApiController
    {
        private readonly CustomerRepository _customerRepo;

        public CustomerController()
        {
            _customerRepo = new CustomerRepository();
        }

        [Route("", Name = "GetAllCustomers")]
        public IHttpActionResult Get()
        {
            var things = _customerRepo.GetAllCustomers().ToList();

            var results = new List<Customer>();

            results.AddRange(things.Select(customer => new Customer
            {
                City = customer.City,
                Country = customer.Country,
                FirstName = customer.FirstName,
                Id = customer.Id,
                LastName = customer.LastName,
                Phone = customer.Phone
            }));

            return Ok(results);
        }

        [Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
            var customer = _customerRepo.GetCustomer(id);

            if (customer == null)
                return BadRequest($"Customer with ID: {id} could not be found");

            return Ok(new Customer
            {
                City = customer.City,
                Country = customer.Country,
                FirstName = customer.FirstName,
                Id = customer.Id,
                LastName = customer.LastName,
                Phone = customer.Phone
            });
        }

        // POST: api/Customer
//        public void Post([FromBody]string value)
//        {
//        }

        [Route("{id:int}")]
        public void Put(int id, [FromBody]string value)
        {
            _customerRepo.SaveCustomer(value);
        }

        // DELETE: api/Customer/5
//        public void Delete(int id)
//        {
//        }
    }
}
