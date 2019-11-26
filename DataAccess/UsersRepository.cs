using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using REST_APi.Model;

namespace REST_APi.DataAccess
{
    static class UsersRepository
    {
        private static List<Users> users;

        static UsersRepository()
        {
            users = new List<Users>()
            { new Users(){
                id = 1,
                name = "Jose Perez",
                active = true
                          },
              new Users(){
                id = 2,
                name = "Juan Jose Perez",
                active = true
                          }
            };
        }

        public static List<Users> GetUsers()
        {
                return users;
        }
        
        public static List<Users> GetUsersAct(bool activeParam)
        {
            if (activeParam != null)
            {
                var usersActive =
                             from i in users
                             where i.active = activeParam
                             select i;

                return (usersActive as List<Users>);
            }
            else
            {
                return users;
            }
        }

        //todo
        //Get all users(query params)
        //Get all active users(query params)
        //Get all inactive users(query params)


        public static Users GetUsersById(int id)
        {
            var index = users.FindIndex(o => o.id == id);
            return users[index];
        }

        public static List<Users> PostUsers(Users group)
        {
            users.Add(group);
            return users;
        }
        public static void DeleteUsers(int id)
        {
            var index = users.FindIndex(o => o.id == id);
            users.Remove(users[index]);
        }
        public static void PutUsers(Users value, int id)
        {
            var index = users.FindIndex(o => o.id == id);
            users[index].name = value.name;
            users[index].active = value.active;

        }

        public static void PatchUsers(Users value, int id)
        {
            var index = users.FindIndex(o => o.id == id);
            if (value.name != users[index].name)
            {
                users[index].name = value.name;
            }
            if (value.active != users[index].active)
            {
                users[index].active = value.active;
            }

        }

    }
}