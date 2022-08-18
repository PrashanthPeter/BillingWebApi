using CustomerbillingWebApi.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerbillingWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            var getCustomers = _context.Customer.ToList();
            return getCustomers;
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return _context.Customer.Where(t=>t.ID == id).FirstOrDefault();
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] Customer value)
        {
            _context.Customer.Add(new Customer { Customer_Name = value.Customer_Name, Address = value.Address});
            _context.SaveChanges();
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer value)
        {
            var customerObj = _context.Customer.Where(t => t.ID == id).FirstOrDefault();
            customerObj.Customer_Name = value.Customer_Name;
            customerObj.Address = value.Address;
            _context.SaveChanges();
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var customerObj = _context.Customer.Where(t => t.ID == id).FirstOrDefault();
            _context.Customer.Remove(customerObj);
            _context.SaveChanges();
        }
    }
}
