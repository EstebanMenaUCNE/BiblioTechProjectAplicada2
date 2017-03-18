using BiblioTechProject.DAL;
using BiblioTechProject.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class EditorialLibroBLL
    {
        public static EditorialLibro Guardar(EditorialLibro editorialLibro)
        {
            using (var repositorio = new Repositorio<EditorialLibro>())
            {
                if (Buscar(A => A.Id == editorialLibro.Id) == null)
                {
                    return repositorio.Guardar(editorialLibro);
                }
                else
                {
                    return repositorio.Modificar(editorialLibro);
                }
            }
        }

        public static EditorialLibro Buscar(Expression<Func<EditorialLibro, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<EditorialLibro>())
            {
                return repositorio.Buscar(criterioBusqueda);
            }
        }

        public static bool Eliminar(EditorialLibro editorialLibro)
        {
            using (var repositorio = new Repositorio<EditorialLibro>())
            {
                return repositorio.Eliminar(editorialLibro);
            }
        }

        public static List<EditorialLibro> GetList(Expression<Func<EditorialLibro, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<EditorialLibro>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }
    }
}
