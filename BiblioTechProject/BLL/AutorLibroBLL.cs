using BiblioTechProject.DAL;
using BiblioTechProject.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class AutorLibroBLL
    {
        public static bool Guardar(AutorLibro autorLibro)
        {
            using (var repositorio = new Repositorio<AutorLibro>())
            {
                if (Buscar(A => A.Id == autorLibro.Id) == null)
                {
                    return repositorio.Guardar(autorLibro);
                }
                else
                {
                    return repositorio.Modificar(autorLibro);
                }
            }
        }

        public static AutorLibro Buscar(Expression<Func<AutorLibro, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<AutorLibro>())
            {
                return repositorio.Buscar(criterioBusqueda);
            }
        }

        public static bool Eliminar(AutorLibro autorLibro)
        {
            using (var repositorio = new Repositorio<AutorLibro>())
            {
                return repositorio.Eliminar(autorLibro);
            }
        }

        public static List<AutorLibro> GetList(Expression<Func<AutorLibro, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<AutorLibro>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }
    }
}
