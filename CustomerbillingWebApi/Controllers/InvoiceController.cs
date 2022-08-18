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
    public class InvoiceController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public InvoiceController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<ItemController>
        [HttpGet]
        public IEnumerable<Invoice> Get()
        {
            var getInvoice = _context.Invoice.ToList();
            return getInvoice;
        }

        // GET api/<ItemController>/5
        [HttpGet("{id}")]
        public Invoice Get(int id)
        {
            return _context.Invoice.Where(t => t.ID == id).FirstOrDefault();
        }

        // POST api/<InvoiceController>
        [HttpPost]
        public void Post([FromBody] Invoice value)
        {
            _context.Invoice.Add(new Invoice { Customer_ID = value.Customer_ID, Invoice_Number = value.Invoice_Number, Created_Date = value.Created_Date });
            _context.SaveChanges();
        }

        // PUT api/<InvoiceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Invoice value)
        {
            var InvoiceObj = _context.Invoice.Where(t => t.ID == id).FirstOrDefault();
            InvoiceObj.Customer_ID = value.Customer_ID;
            InvoiceObj.Invoice_Number = value.Invoice_Number;
            InvoiceObj.Created_Date = value.Created_Date;
            _context.SaveChanges();
        }

        // DELETE api/<InvoiceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var InvoiceObj = _context.Invoice.Where(t => t.ID == id).FirstOrDefault();
            _context.Invoice.Remove(InvoiceObj);
            _context.SaveChanges();
        }
    }
}
