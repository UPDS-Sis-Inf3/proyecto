using REST_APi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using REST_APi.DataAccess;

namespace REST_APi.Busines
{
	public class usuariobusines : Ius
	{

        public IList<Users> readAll()
        {
            return UsersRepository.GetUsers();
        }

        public Users create(Users entity)
        {
            Users users2 = new Users();
            users2 = UsersRepository.PostUsers(entity);
            return users2;

        }
        
        public Users update(Users entity)
        {
            Users users3 = new Users();
            //users3 = UsersRepository. .PutUsuario(id);
            return users3;
        }
        public Users delete(Users entity)
        {
            Users users4 = new Users();
            users4 = UsersRepository.DeleteUsers(entity);
            return users4;
        }

    }
}
