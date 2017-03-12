using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblioTechProject.BLL
{
    public class UsuarioBLL
    {
        public static bool Guardar(Entidades.Usuario usuario)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Usuario>())
            {
                if (repositorio.Buscar(U => U.UsuarioId == usuario.UsuarioId) == null)
                {
                    return repositorio.Guardar(usuario) != null;
                }
                else
                {
                    return repositorio.Modificar(usuario);
                }
            }            
        }

        public static Entidades.Usuario Buscar(Entidades.Usuario usuario)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Usuario>())
            {
                return repositorio.Buscar(U => U.UsuarioId == usuario.UsuarioId);
            }
        }

        public static bool Eliminar(Entidades.Usuario usuario)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Usuario>())
            {
                return repositorio.Eliminar(usuario);
            }
        }

        public static List<Entidades.Usuario> GetList()
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Usuario>())
            {
                return repositorio.GetList(U => U.UsuarioId > 0);
            }
        }

        public static List<Entidades.Usuario> GetListNombre(string nombre)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Usuario>())
            {
                return repositorio.GetList(U => U.Nombre == nombre);
            }
        }

        public static List<Entidades.Usuario> GetListNombreUsuario(string nombreUsuario)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Usuario>())
            {
                return repositorio.GetList(U => U.NombreUsuario == nombreUsuario);
            }
        }

        public static List<Entidades.Usuario> GetListId(int id)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Usuario>())
            {
                return repositorio.GetList(U => U.UsuarioId == id);
            }
        }

    }
}
