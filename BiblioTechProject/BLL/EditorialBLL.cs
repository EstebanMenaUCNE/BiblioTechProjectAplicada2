using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BiblioTechProject.BLL
{
    public class EditorialBLL
    {
        public static bool Guardar(Entidades.Editorial editorial)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Editorial>())
            {
                if (Buscar(E => E.EditorialId == editorial.EditorialId) == null)
                {
                    return repositorio.Guardar(editorial) != null;
                }
                else
                {
                    return repositorio.Modificar(editorial);
                }
            }
        }

        public static Entidades.Editorial Buscar(Expression<Func<Entidades.Editorial, bool>> criterioBusqueda)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Editorial>())
            {
                return repositorio.Buscar(criterioBusqueda);
            }
        }

        public static bool Eliminar(Entidades.Editorial editorial)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Editorial>())
            {
                return repositorio.Eliminar(editorial);
            }
        }

        public static List<Entidades.Editorial> GetList(Expression<Func<Entidades.Editorial, bool>> criterioBusqueda)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Editorial>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }

        /*
        public static List<Entidades.Editorial> GetListNombre(string nombre)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Editorial>())
            {
                return repositorio.GetList(E => E.Nombre == nombre);
            }
        }

        public static List<Entidades.Editorial> GetListId(int id)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Editorial>())
            {
                return repositorio.GetList(E => E.EditorialId == id);
            }
        }
        */

    }
}
