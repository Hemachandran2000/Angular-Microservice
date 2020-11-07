using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartDAL.Interface;
using ShoppingCartDAL.UnitOfWork;
using ShoppingCartDTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppingCartApi.Controllers
{    
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IUnitWork _products;
        public ProductsController(IUnitWork products)
        {
            _products = products;
        }
        // GET: api/<ProductsController>
        [Authorize(Roles = "admin")]
        [HttpGet]
        public IEnumerable<Productsdto> Get()
        {
            return _products.ProductsRepo.GetAll();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
