using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using REST_APi.DataAccess;
using REST_APi.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REST_APi.Controllers
{
    [Route("api/[controller]")]
    public class UsersGroupsController : Controller
    {
        // GET api/Users
        [HttpGet("{group}")]
        public ActionResult<IEnumerable<UserDGroupD>> Get(int group)
        {

            return UsersGroupsRepository.GetUsersByGroup(group);
            //return l1;
        }

        // POST api/Users
        [HttpPost]
        public ActionResult Post([FromBody] UsersGroups value)
        {

            UsersGroupsRepository.PostUserOnGroup(value);
            return this.Ok();
        }

        // delete api/Users
        [HttpDelete]
        public ActionResult delete([FromBody] UsersGroups value)
        {

            UsersGroupsRepository.DeleteUserOnGroup(value);
            return this.Ok();
        }
    }
}
