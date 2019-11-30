using REST_APi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using REST_APi.DataAccess;



/// <summary>
/// Summary description for Class1
/// </summary>
namespace REST_APi.Busines
{
    public class tareasbusines : Itareas
    {
        //
        // TODO: Add constructor logic here
        //
        public IList<Tareas> readAll()
        {
            return TareasRepository.GetTareas();
        }

        public Tareas create(Tareas entity)
        {
            Tareas tarea1 = new Tareas();
            tarea1 = TareasRepository.Posttareas(entity);
            return tarea1;

        }

        public Tareas update(Tareas entity)
        {
            Tareas tarea2 = new Tareas();
            //tarea2 = TareasRepository.PutTareas(id);
            return tarea2;
        }
        public Tareas delete(Tareas entity)
        {
            Tareas tarea3 = new Tareas();
            tarea3 = TareasRepository.Deletetarea(entity);
            return tarea3;
        }

    }
}
