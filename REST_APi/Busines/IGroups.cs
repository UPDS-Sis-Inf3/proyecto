using REST_APi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_APi.Busines
{
    public interface IGroups<T>
    {
        List<T> readAll();
        T create(T entity);
        T read(Tareas Todo);
        T update(T entity);
        T delete(T entity);

    }
}
