using REST_APi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_APi.DataAccess
{
    static class GroupsRepository
    {
         private static List<Groups> groups;

         static GroupsRepository()
        {
            groups = new List<Groups>()
            { new Groups(){
                id = 1,
                name = "Test"
                          },
              new Groups(){
                id = 2,
                name = "Guest"
                          }
            };
        }

        public static List<Groups> GetGroups()
        {
           
            return groups;
        }
        public static Groups GetGroupsById(int id)
        {
            var index = groups.FindIndex(o => o.id == id);
            return groups[index];
        }

        public static List<Groups> PostGroups(Groups group)
        {
            groups.Add(group);
            return groups;


        }
        public static void DeleteGroups(int id)
        {
            var index = groups.FindIndex(o => o.id == id);
            groups.Remove(groups[index]);
        }
        public static void PutGroups(Groups value,int id)
        {
            var index = groups.FindIndex(o => o.id == id);
            groups[index].name = value.name;

        }

        public static void PatchGroups(Groups value, int id)
        {
            var index = groups.FindIndex(o => o.id == id);
            if (value.name != groups[index].name)
            { 
                groups[index].name = value.name;
            }

        }

    }
}
