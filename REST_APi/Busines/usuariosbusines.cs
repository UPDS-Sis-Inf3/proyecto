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
	public class usuariobusines : Ius
	{
        //
        // TODO: Add constructor logic here
        //
        public List<Users> readAll()
        {
            return UsuarioRepository.GetUsuario;
        }

        public Users create(Users entity)
        {
            Users users2 = new create<Users>();
            users2 = UsuarioRepository.PatchUsuario(entity);
            returns Users2;

        }
        
        public Users update(Users entity)
        {
            Users users3 = new update<Users>(id);
            users3 = UsuarioRepository.PutUsuario(id);
            returns users3;
        }
        public Users delete(Users entity)
        {
            Users users4 = new delete<Users>(id);
            users4 = UsuarioRepository.DeleteUsuario(Users);
            returns users4;
        }

    }
}
