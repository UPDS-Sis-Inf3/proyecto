using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using REST_APi.Model;

namespace REST_APi.DataAccess
{
    static class UsuarioRepository
    {
        private static List<Usuario> users;

        static UsuarioRepository()
        {
            users = new List<Usuario>()
            { new Usuario(){
                id = 1,
                nombre = "Jose",
                ap_materno = "Perez",
                ap_paterno = "Valdez",
                emal = "JosePerez@Gmail.com"
                          },
              new Usuario(){
                 id = 2,
                nombre = "Juan",
                ap_materno = "Pacheco",
                ap_paterno = "Perez",
                emal = "JuanPacheco@Gmail.com" 
                          },
                new Usuario(){
                 id = 3,
                nombre = "Jose",
                ap_materno = "Perez",
                ap_paterno = "Valdez",
                emal = "JosePerez@Gmail.com" 
                          },
                new Usuario(){
                 id = 4,
                nombre = "Jose",
                ap_materno = "Perez",
                ap_paterno = "Valdez",
                emal = "JosePerez@Gmail.com"
                          }
            };
        }

        public static List<Usuario> GetUsuario()
        {
                return usuario;
        }
        
        public static List<Usuario> GetUsuarioAct(bool activeParam)
        {
            if (activeParam != null)
            {
                var usuariosActive =
                             from i in usuario
                             where i.active = activeParam
                             select i;

                return (usuariosActive as List<Usuario>);
            }
            else
            {
                return usuario;
            }
        }

        //todo
        //Get all users(query params)
        //Get all active users(query params)
        //Get all inactive users(query params)


        public static Usuario GetUsuarioById(int id)
        {
            var index = usuario.FindIndex(o => o.id == id);
            return usuario[index];
        }

        public static List<Usuario> PostUsuario(Usuario group)
        {
            usuario.Add(tarea);
            return usuario;
        }
        public static void DeleteUsuario(int id)
        {
            var index = usuario.FindIndex(o => o.id == id);
            usuario.Remove(usuario[index]);
        }
        public static void PutUsuario(Usuario value, int id)
        {
            var index = usuario.FindIndex(o => o.id == id);
            usuario[index].Name = value.Name;

        }

        public static void PatchUsuario(Usuario value, int id)
        {
            var index = users.FindIndex(o => o.id == id);
            if (value.Name != usuario[index].Name)
            {
                usuario[index].Name = value.Name;
            }

        }

    }
}