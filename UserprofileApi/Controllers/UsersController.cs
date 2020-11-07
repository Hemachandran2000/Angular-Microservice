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

namespace UserprofileApi.Controllers
{
    [Authorize] 
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUnitWork _users; 
        public UsersController(IUnitWork users)
        {
            _users = users;
        }
        // GET: api/<UsersController>
        [Authorize(Roles = "admin, user")]
        [HttpGet]
        public IEnumerable<Userdto> Get()
        {
            return _users.UsersRepo.GetAll();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
