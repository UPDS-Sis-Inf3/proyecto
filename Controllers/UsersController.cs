using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using REST_APi.DataAccess;
using REST_APi.Model;

namespace REST_APi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET api/Users
        [HttpGet]
        public ActionResult<IEnumerable<Users>> Get()
        {
            return UsersRepository.GetUsers();
        }


        // GET api/Users
        [HttpGet("{activeParam}")]
        public ActionResult<IEnumerable<Users>> GetUsersAct(bool activeParam)
        {
            return UsersRepository.GetUsersAct(activeParam);
        }

        


        // GET api/Users/5
        [HttpGet("{id}")]
        public ActionResult<Users> Get(int id)
        {
            return UsersRepository.GetUsersById(id);
        }

        // POST api/Users
        [HttpPost]
        public ActionResult Post([FromBody] Users value)
        {
            List<Users> users = new List<Users>();
            users = UsersRepository.PostUsers(value);
            return this.Ok();
        }

        // PUT api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Users value)
        {
            UsersRepository.PutUsers(value, id);
        }

        // DELETE api/Users/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            UsersRepository.DeleteUsers(id);
        }

        // PATCH api/groups/5
        [HttpPatch("{id}")]
        public void Patch(int id, [FromBody] Users value)
        {
            UsersRepository.PatchUsers(value, id);
        }
    }
}
