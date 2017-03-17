using BiblioTechProject.DAL;
using BiblioTechProject.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BiblioTechProject.BLL
{
    public class AutorBLL
    {
        public static Entidades.Autor Guardar(Entidades.Autor autor)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Autor>())
            {
                if (Buscar(A => A.AutorId == autor.AutorId) == null)
                {
                    return repositorio.Guardar(autor);
                }
                else
                {
                    return repositorio.Modificar(autor);
                }
            }
        }

        public static Entidades.Autor Buscar(Expression<Func<Entidades.Autor, bool>> criterioBusqueda)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Autor>())
            {
                return repositorio.Buscar(criterioBusqueda);
            }
        }

        public static bool Eliminar(Entidades.Autor autor)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Autor>())
            {
                return repositorio.Eliminar(autor);
            }
        }

        public static List<Entidades.Autor> GetList(Expression<Func<Entidades.Autor, bool>> criterioBusqueda)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Autor>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }

        /*public static List<Entidades.Autor> GetListNombre(string nombre)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Autor>())
            {
                return repositorio.GetList(A => A.Nombre == nombre);
            }
        }

        public static List<Entidades.Autor> GetListId(int id)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Autor>())
            {
                return repositorio.GetList(A => A.AutorId == id);
            }
        }*/
    }
}
