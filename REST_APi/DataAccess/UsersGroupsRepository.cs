using REST_APi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_APi.DataAccess
{
    public class UsersGroupsRepository
    {
        public static List<UsersGroups> usersgroups;

        static UsersGroupsRepository()
        {
            usersgroups = new List<UsersGroups>()
            { new UsersGroups(){
                UserId = 1,
                GroupId=1
                          },
              new UsersGroups(){
                UserId = 1,
                GroupId=2
                          }
            };
        }

        public static List<UserDGroupD> GetUsersByGroup(int value)
        {
            List<Users> TempUsers = DataAccess.UsersRepository.users;
            List<tareas> TempGroups = DataAccess.GroupsRepository.groups;
            var res = from i in TempUsers
                      from j in TempGroups
                      from k in usersgroups
                      where k.GroupId.Equals(value) && i.id.Equals(k.UserId) && j.id.Equals(k.GroupId)
                      select new
                      {
                          Userid=i.id,
                          Username=i.name,
                          Useractive=i.active,
                          Groupname=j.name
                      };
            var ResUserDGroupD = new UserDGroupD();
            List<UserDGroupD> ResUserDGroupDs = new List<UserDGroupD>();
            foreach (var item in res)
            {
                ResUserDGroupD.Userid = item.Userid;
                ResUserDGroupD.Username = item.Username;
                ResUserDGroupD.Useractive = item.Useractive;
                ResUserDGroupD.Groupname = item.Groupname;
                ResUserDGroupDs.Add(ResUserDGroupD);
            }

            return ResUserDGroupDs;
        }

        public static void PostUserOnGroup(UsersGroups value) 
        {
            usersgroups.Add(value);
        }
        public static void DeleteUserOnGroup(UsersGroups value)
        {
     
            var index = usersgroups.FindIndex(o => o.UserId == value.UserId && o.GroupId==value.GroupId);
            usersgroups.Remove(usersgroups[index]);

        }



    }
}
