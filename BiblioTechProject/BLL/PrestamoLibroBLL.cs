using BiblioTechProject.DAL;
using BiblioTechProject.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class PrestamoLibroBLL
    {
        public static PrestamoLibro Guardar(PrestamoLibro prestamoLibro)
        {
            using (var repositorio = new Repositorio<PrestamoLibro>())
            {
                if (Buscar(A => A.Id == prestamoLibro.Id) == null)
                {
                    return repositorio.Guardar(prestamoLibro);
                }
                else
                {
                    return repositorio.Modificar(prestamoLibro);
                }
            }
        }

        public static PrestamoLibro Buscar(Expression<Func<PrestamoLibro, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<PrestamoLibro>())
            {
                return repositorio.Buscar(criterioBusqueda);
            }
        }

        public static bool Eliminar(PrestamoLibro autorLibro)
        {
            using (var repositorio = new Repositorio<PrestamoLibro>())
            {
                return repositorio.Eliminar(autorLibro);
            }
        }

        public static List<PrestamoLibro> GetList(Expression<Func<PrestamoLibro, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<PrestamoLibro>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }
    }
}
