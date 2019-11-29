using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
                nombre = "Jose Perez"
                          },
              new Users(){
                id = 2,
                nombre = "Juan Jose Perez"

                          }
            };
        }

        public static List<Users> GetUsers()
        {
            using (var db = new EntityFrameworkSQLite())
            {
                ICollection<Users> us = new Collection<Users>();
                List<Users> l2 = new List<Users>();
                Users u = new Users();
                foreach (Users item in db.User)
                {
                    // Console.WriteLine(item);
                    u.nombre = item.nombre;
                    l2.Add(u);

                }

                //us.Add(db.User);
                return l2;// db.User;//.ToList<Users>;

            }
           /// return users;
        }

        public static List<Users> GetUsersAct(string activeParam)
        {
            List<Users> l2 = new List<Users>();
            if (activeParam != "all")
            {
                foreach (Users item in users)
                {
                    // Console.WriteLine(item);
                    if (item.id == 1)//Convert.ToBoolean(activeParam))
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
            users[index].nombre = value.nombre;
            ////users[index].active = value.active;

        }

        public static void PatchUsers(Users value, int id)
        {
            var index = users.FindIndex(o => o.id == id);
            if (value.nombre != users[index].nombre)
            {
                users[index].nombre = value.nombre;
            }
            

        }

    }
}