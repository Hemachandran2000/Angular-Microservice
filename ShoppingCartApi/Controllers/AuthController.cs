using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ShoppingCartApi.AuthService;
using ShoppingCartDAL.Interface;
using ShoppingCartDAL.UnitOfWork;
using ShoppingCartDTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppingCartApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IConfiguration _config;
        private IUnitWork _users;
        public AuthController(IConfiguration config, IUnitWork users)
        {
            _config = config;
            _users = users;
        }

        [Route("Token")]
        [HttpGet]
        public string GenerateToken()
        {
            var jwt = new TokenService(_config);
            Userdto userDTO = _users.UsersRepo.GetAll().FirstOrDefault<Userdto>();
            var token = jwt.GenerateSecurityToken(userDTO.UserName, userDTO.UserRole);
            return token;
        }

        // GET: api/<AuthController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AuthController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AuthController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AuthController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AuthController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
