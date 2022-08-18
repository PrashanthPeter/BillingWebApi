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
    public class ItemsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<ItemController>
        [HttpGet]
        public IEnumerable<Items> Get()
        {
            var getItems = _context.Items.ToList();
            return getItems;
        }

        // GET api/<ItemController>/5
        [HttpGet("{id}")]
        public Items Get(int id)
        {
            return _context.Items.Where(t => t.ID == id).FirstOrDefault();
        }

        // POST api/<ItemsController>
        [HttpPost]
        public void Post([FromBody] Items value)
        {
            _context.Items.Add(new Items { Name = value.Name, Code = value.Code, Price = value.Price });
            _context.SaveChanges();
        }

        // PUT api/<ItemsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Items value)
        {
            var ItemsObj = _context.Items.Where(t => t.ID == id).FirstOrDefault();
            ItemsObj.Name = value.Name;
            ItemsObj.Code = value.Code;
            ItemsObj.Price = value.Price;
            _context.SaveChanges();
        }

        // DELETE api/<ItemsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var ItemsObj = _context.Items.Where(t => t.ID == id).FirstOrDefault();
            _context.Items.Remove(ItemsObj);
            _context.SaveChanges();
        }
    }
}
