using System;
using REST_APi.Model;
using REST_APi.DataAccess;
//using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace REST_APi.Busines
{
    public class BUsers
    {
        public void CreateUsers(Users users)
        {
            using (var db = new EntityFrameworkSQLite())
            {
               // ICollection<Users> users1 = new Collection<Users>();

                db.User.Add(users);
                ///db.User.Add(users);
                var count = db.SaveChanges();

                //Console.WriteLine("{0} records saved to database", count);

                //Console.WriteLine();
                
            }
        }




    }
}
