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
        public ActionResult<IEnumerable<Tareas>> GetUsersAct(string activeParam = "all")
        {
            //List<Users> l1 = new List<Users>();
            //l1 =UsersRepository.GetUsersAct(activeParam);
            ///return l1;
            return Ok(UsersRepository.GetUsers());
        }

        // GET api/Users/5
        [HttpGet("{id}")]
        public ActionResult<Tareas> Get(int id)
        {
            Tareas t = new Tareas();
            return TareasRepository.GetTareasPorId(t);
        }

        // POST api/Users
        [HttpPost]
        public ActionResult Post([FromBody] Tareas value)
        {
            IList<Tareas> tareas = new List<Tareas>();
            tareas = (System.Collections.Generic.IList<REST_APi.Model.Tareas>)TareasRepository.Posttareas(value);
            return this.Ok(tareas);
        }

        // DELETE api/Users/5
        [HttpDelete("{id}")]
        public void DeleteTareas(int id)
        {
            Tareas t = new Tareas();
            t.id = id;
            TareasRepository.Deletetarea(t);
        }

    }
}
