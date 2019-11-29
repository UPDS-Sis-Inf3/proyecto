using REST_APi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_APi.DataAccess
{
    static class TareasRepository
    {
         private static List<Tareas> groups;

         static TareasRepository()
        {
            groups = new List<Tareas>()
            { new Tareas(){
                id = 1,
                descripcion = "Test1",
                estado = "A",
                fecha = "03/02/2019"
                          },
                new Tareas(){
                id = 2,
                descripcion = "Test2",
                estado = "A",
                fecha = "03/03/2019"
                          },
                new Tareas(){
                id = 3,
                descripcion = "Test3",
                estado = "D",
                fecha = "03/04/2019"
                          },
                new Tareas(){
                id = 4,
                descripcion = "Test4",
                estado = "D",
                fecha = "03/05/2019"
                          },
            };
        }



        public static List<Tareas> GetTareas()
        {
           
            return tareas;
        }
        public static Tareas GetTareasById(int id)
        {
            var index = tareas.FindIndex(o => o.id == id);
            return tareas[index];
        }

        public static List<Tareas> PostTareas(Tareas group)
        {
            tareas.Add(tareas);
            return tareas;


        }
        public static void DeleteTareas(int id)
        {
            var index = tareas.FindIndex(o => o.id == id);
            tareas.Remove(tareas[index]);
        }
        public static void PutTareas(Tareas value,int id)
        {
            var index = tareas.FindIndex(o => o.id == id);
            groups[index].Name = value.Name;
            usuario[index].Estado = value.Estado;

        }

        public static void PatchTareas(Tareas value, int id)
        {
            var index = tareas.FindIndex(o => o.id == id);
            if (value.Name != tareas[index].Name)
            { 
                tareas[index].Name = value.Name;
            }
             if (value.Estado != tareas[index].Estado)
            {
                tareas[index].Estado = value.Estado;
            }

        }

    }
}
