using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using REST_APi.Model;

namespace REST_APi.DataAccess
{
    static class TareasRepository
    {
        public static IList<Tareas> GetUsers()
        {
            using (var db = new EntityFrameworkSQLite())
            {
                ICollection<Tareas> us = new Collection<Tareas>();
                List<Tareas> l2 = new List<Tareas>();
                Tareas u = new Tareas();
                foreach (Tareas tarea in db.Tarea)
                {
                    // Console.WriteLine(item);
                    //u.nombre = item.nombre;
                    l2.Add(tarea);

                }

                //us.Add(db.User);
                return l2 as IList<Tareas>;//.ToList<Users>;

            }
            /// return users;
        }

        public static Tareas GetTareasPorId(Tareas id_tarea)
        {

            using (var db = new EntityFrameworkSQLite())
            {

                id_tarea = db.Tarea.Find(id_tarea.id);
                return id_tarea;
            }
        }
        public static Tareas Posttareas(Tareas tareas)
        {
            using (var db = new EntityFrameworkSQLite())
            {

                db.Tarea.Add(tareas);
                var count = db.SaveChanges();

            }
            return tareas;
        }
        public static Tareas Deletetarea(Tareas tareas)
        {
            using (var db = new EntityFrameworkSQLite())
            {

                db.Tarea.Remove(tareas);
                var count = db.SaveChanges();

            }
            return tareas;
        }


    }

}