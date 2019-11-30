﻿using System;
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
    public class GroupsController : Controller
    {
        // GET api/groups
        [HttpGet]
        public ActionResult<IEnumerable<tareas>> Get()
        {
            return this.Ok(); //return GroupsRepository.GetGroups();
        }
        // GET api/groups/5
        [HttpGet("{id}")]
        public ActionResult<tareas> Get(int id)
        {
            return Ok(); //return GroupsRepository.GetGroupsById(id);
        }

        // POST api/groups
        [HttpPost]
        public ActionResult Post([FromBody] tareas value)
        {
            List<tareas> groups = new List<tareas>();
             //groups=GroupsRepository.PostGroups(value);
            return this.Ok();
        }

        // PUT api/groups/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] tareas value)
        {
             //GroupsRepository.PutGroups(value,id);
        }

        // DELETE api/groups/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ///GroupsRepository.DeleteGroups(id);
        }

        // PATCH api/groups/5
        [HttpPatch("{id}")]
        public void Patch(int id, [FromBody] tareas value)
        {
            //GroupsRepository.PatchGroups(value, id);
        }

    }
}