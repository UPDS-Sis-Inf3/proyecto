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
    public class usuariobusines : Itareas
    {
        //
        // TODO: Add constructor logic here
        //
        public List<Tareas> readAll()
        {
            return TareasRepository.GetTareas;
        }

        public Tareas create(Tareas entity)
        {
            Tareas tarea1 = new create<Tareas>();
            tarea1 = TareasRepository.PatchTareas(entity);
            returns tarea1;

        }

        public Tareas update(Tareas entity)
        {
            Tareas tarea2 = new update<Tareas>(id);
            tarea2 = TareasRepository.PutTareas(id);
            returns tarea2;
        }
        public Tareas delete(Tareas entity)
        {
            Tareas tarea3 = new delete<Tareas>(id);
            tarea3 = TareasRepository.DeleteTareas(id);
            returns tarea13;
        }

    }
}
