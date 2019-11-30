using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_APi.Model
{
    public class tareas
    {
        public int id { get; set; }//id del usuario añadir
        public string descripcion { get; set; }
        public char estado { get; set; }
        public DateTime fecha { get; set; }

    }
}
