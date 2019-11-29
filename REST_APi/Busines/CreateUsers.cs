using System;
using REST_APi.Model;
using REST_APi.DataAccess;
//using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace REST_APi.Busines
{
    public class BUsers
    {
        public void CreateUsers(Users users)
        {
            using (var db = new EntityFrameworkSQLite())
            {
                db.User.Add(users);
                var count = db.SaveChanges();          
            }
        }
        public IList<Users> ReadUsers()
        {
            using (var db = new EntityFrameworkSQLite())
            {
                return (IList<Users>)db.User;
            }
        }
    }
}
