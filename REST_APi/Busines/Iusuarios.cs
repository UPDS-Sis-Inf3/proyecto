using REST_APi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using REST_APi.DataAccess;

namespace REST_APi.Busines
{
    public interface Ius
    {
        List<Users> readAll();
        Users create(Users entity);
        //user read(Groups Todo);
        Users update(Users entity);
        Users delete(Users entity);

    }
}



