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
    public class InvoiceitemsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public InvoiceitemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<InvoiceitemsController>
        [HttpGet]
        public IEnumerable<Invoiceitems> Get()
        {
            var getInvoiceitems = _context.Invoiceitems.ToList();
            return (IEnumerable<Invoiceitems>)getInvoiceitems;
        }

        // GET api/<InvoiceitemsController>/5
        [HttpGet("{id}")]
        public Invoiceitems Get(int id)
        {
            return _context.Invoiceitems.Where(t => t.ID == id).FirstOrDefault();
        }

        // POST api/<InvoiceitemsController>
        [HttpPost]
        public void Post([FromBody] Invoiceitems value)
        {
            _context.Invoiceitems.Add(new Invoiceitems { InvoiceID = value.InvoiceID, ItemID = value.ItemID, Price = value.Price });
            _context.SaveChanges();
        }

        // PUT api/<InvoiceitemsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Invoiceitems value)
        {
            var InvoiceitemsObj = _context.Invoiceitems.Where(t => t.ID == id).FirstOrDefault();
            InvoiceitemsObj.InvoiceID = value.InvoiceID;
            InvoiceitemsObj.ItemID = value.ItemID;
            InvoiceitemsObj.Price = value.Price;
            _context.SaveChanges();
        }

        // DELETE api/<InvoiceitemseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var InvoiceitemsObj = _context.Invoiceitems.Where(t => t.ID == id).FirstOrDefault();
            _context.Invoiceitems.Remove(InvoiceitemsObj);
            _context.SaveChanges();
        }
    }
}
