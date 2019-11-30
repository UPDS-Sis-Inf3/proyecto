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
        public static IList<Users> GetUsers()
        {
            using (var db = new EntityFrameworkSQLite())
            {
                ICollection<Users> us = new Collection<Users>();
                List<Users> l2 = new List<Users>();
                Users u = new Users();
                foreach (Users item in db.User)
                {
                    // Console.WriteLine(item);
                    //u.nombre = item.nombre;
                    l2.Add(item);

                }

                //us.Add(db.User);
                return l2 as IList<Users>;//.ToList<Users>;

            }
            /// return users;
        }

        public static Users GetUsersPorId(Users id_users)
        {
            
            using (var db = new EntityFrameworkSQLite())
            {

                id_users = db.User.Find(id_users.id);
                return id_users;
            }
        }

        public static Users PostUsers(Users users)
        {
            using (var db = new EntityFrameworkSQLite())
            {

                db.User.Add(users);
                var count = db.SaveChanges();

            }
            return users;
        }   
        public static Users DeleteUsers(Users users)
        {
            using (var db = new EntityFrameworkSQLite())
            {

                db.User.Remove(users);
                var count = db.SaveChanges();

            }
            return users;
        }

        

    }
}