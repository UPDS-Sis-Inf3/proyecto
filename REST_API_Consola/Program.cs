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
                Users U2 = new Users();
                
                U2.nombre = "Algo";
                db.User.Add(U2);
                ///db.User.Add(users);
                try
                {
                    var count = db.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"The file was not found: '{ex}'");
                }
                

                ///Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var blog in db.User)
                {
                    Console.WriteLine(" - {0}", blog.nombre);
                }
            }
        }
    }
}
