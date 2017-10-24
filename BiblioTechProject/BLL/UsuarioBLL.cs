using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BiblioTechProject.BLL
{
    public class UsuarioBLL
    {
        public static bool Guardar(Entidades.Usuario usuario)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Usuario>())
            {
                if (Buscar(U => U.UsuarioId == usuario.UsuarioId) == null)
                {
                    return repositorio.Guardar(usuario);
                }
                else
                {
                    return repositorio.Modificar(usuario);
                }
            }            
        }

        public static Entidades.Usuario Buscar(Expression<Func<Entidades.Usuario, bool>> criterioBusqueda)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Usuario>())
            {
                return repositorio.Buscar(criterioBusqueda);
            }
        }

        public static bool Eliminar(Entidades.Usuario usuario)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Usuario>())
            {
                return repositorio.Eliminar(usuario);
            }
        }

        public static List<Entidades.Usuario> GetList(Expression<Func<Entidades.Usuario, bool>> criterioBusqueda)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Usuario>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }

        public static bool Autenticar(string nombreUsuario, string contrasena)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Usuario>())
            {
                foreach (var usuario in GetList(P => P.UsuarioId > 0))
                {
                    if (nombreUsuario == usuario.NombreUsuario && contrasena == usuario.Contrasena)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        /*
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
        */
    }
}
