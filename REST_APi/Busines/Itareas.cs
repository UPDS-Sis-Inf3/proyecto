using REST_APi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using REST_APi.DataAccess;

namespace REST_APi.Busines
{
    public interface Itareas
    {
        IList<Tareas> readAll();
        Tareas create(Tareas entity);
        //user read(Groups Todo);
        Tareas update(Tareas entity);
        Tareas delete(Tareas entity);

    }
}



