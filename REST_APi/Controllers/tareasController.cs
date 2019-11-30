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
    public class tareaController : ControllerBase
    {
        // GET api/Users
        //[HttpGet]

        // GET api/Users
        [HttpGet]
        public ActionResult<IEnumerable<tareas>> GetUsersAct(string activeParam = "all")
        {
            //List<Users> l1 = new List<Users>();
            //l1 =UsersRepository.GetUsersAct(activeParam);
            ///return l1;
            return Ok(UsersRepository.GetUsers());
        }

        // GET api/Users/5
        [HttpGet("{id}")]
        public ActionResult<tareas> Get(int id)
        {
            return tareaRepository.GettareasById(id);
        }

        // POST api/Users
        [HttpPost]
        public ActionResult Post([FromBody] tareas value)
        {
            List<tareas> tareas = new List<tareas>();
            tareas = tareaRepository.Posttareas(value);
            return this.Ok();
        }

        // DELETE api/Users/5
        [HttpDelete("{id}")]
        public void Deletetareas(int id)
        {
            tareaRepository.Deletetareas(id);
        }

    }
}
