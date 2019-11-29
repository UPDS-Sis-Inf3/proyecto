using System;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    
    using System.IO;
    using System.Linq;
using REST_APi.DataAccess;
using REST_APi.Model;

namespace REST_API_Consola
{
    class Program
    {
        public static void Main()
        {
            using (var db = new EntityFrameworkSQLite())
            {
                ICollection<Users> users = new Collection<Users>();

                db.User.Add(new Users
                {
                    id = 1,
                   name = "Roger Ruiz",
                    active = true
                });
                ///db.User.Add(users);
                var count = db.SaveChanges();

                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var blog in db.User)
                {
                    Console.WriteLine(" - {0}", blog.name);
                }
            }
        }
    }
}
