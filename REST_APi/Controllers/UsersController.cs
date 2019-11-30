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
    public class UsersController : ControllerBase
    {
        // GET api/Users
        //[HttpGet]

        // GET api/Users
        [HttpGet]
        public ActionResult<IEnumerable<Users>> GetUsersAct(string activeParam = "all")
        {
            //List<Users> l1 = new List<Users>();
            //l1 =UsersRepository.GetUsersAct(activeParam);
            ///return l1;
            return Ok(UsersRepository.GetUsers());
        }

        // GET api/Users/5
        [HttpGet("{id}")]
        public ActionResult<Users> Get(int id)
        {
            Users u = new Users();
            u.id = id;
            return UsersRepository.GetUsersPorId(u);
        }

        // POST api/Users
        [HttpPost]
        public ActionResult Post([FromBody] Users value)
        {
            IList<Users> users = new List<Users>();
            users = (System.Collections.Generic.IList<REST_APi.Model.Users>)UsersRepository.PostUsers(value);
            return this.Ok(users);
        }

        // DELETE api/Users/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Users u = new Users();
            u.id = id;
            UsersRepository.DeleteUsers(u);
        }
    }
}