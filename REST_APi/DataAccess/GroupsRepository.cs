using REST_APi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_APi.DataAccess
{
    static class GroupsRepository
    {
         public static List<tareas> groups;

         static GroupsRepository()
        {
            groups = new List<tareas>()
            { new tareas(){
                id = 1,
                name = "Test"
                          },
              new tareas(){
                id = 2,
                name = "Guest"
                          }
            };
        }

        public static List<tareas> GetGroups()
        {
           
            return groups;
        }
        public static tareas GetGroupsById(int id)
        {
            var index = groups.FindIndex(o => o.id == id);
            return groups[index];
        }

        public static List<tareas> PostGroups(tareas group)
        {
            groups.Add(group);
            return groups;


        }
        public static void DeleteGroups(int id)
        {
            var index = groups.FindIndex(o => o.id == id);
            groups.Remove(groups[index]);
        }
        public static void PutGroups(tareas value,int id)
        {
            var index = groups.FindIndex(o => o.id == id);
            groups[index].name = value.name;

        }

        public static void PatchGroups(tareas value, int id)
        {
            var index = groups.FindIndex(o => o.id == id);
            if (value.name != groups[index].name)
            { 
                groups[index].name = value.name;
            }

        }

    }
}
