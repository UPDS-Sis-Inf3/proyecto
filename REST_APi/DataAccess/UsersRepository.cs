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
        public static List<Users> users;

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
                active = false
                          }
            };
        }

        public static List<Users> GetUsers()
        {
                return users;
        }

        public static List<Users> GetUsersAct(string activeParam)
        {
            List<Users> l2 = new List<Users>();
            if (activeParam != "all")
            {
                foreach (Users item in users)
                {
                    // Console.WriteLine(item);
                    if (item.active == Convert.ToBoolean(activeParam))
                    {
                        l2.Add(item);
                    }
                }
                return l2;

                //return usersActive.ToList();

            }
            else
            {
                return users;
            }
        }

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