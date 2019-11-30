using System;
using REST_APi.Model;
using REST_APi.DataAccess;
namespace REST_APi.Busines
{
    public class BTareas
        
    {
        public void UpdateTareas(tareas Tareas)
        {
            using (var db= new EntityFrameworkSQLite())
            {
                db.Tarea.Update(Tareas);
                var count = db.SaveChanges();
            }


        }
    }
}
