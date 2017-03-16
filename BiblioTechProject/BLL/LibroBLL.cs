using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BiblioTechProject.BLL
{
    public class LibroBLL
    {
        public static bool Guardar(Entidades.Libro libro)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Libro>())
            {
                if (Buscar(L => L.LibroId == libro.EditorialId) == null)
                {
                    return repositorio.Guardar(libro) != null;
                }
                else
                {
                    return repositorio.Modificar(libro);
                }
            }
        }

        public static Entidades.Libro Buscar(Expression<Func<Entidades.Libro, bool>> criterioBusqueda)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Libro>())
            {
                return repositorio.Buscar(criterioBusqueda);
            }
        }

        public static bool Eliminar(Entidades.Libro libro)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Libro>())
            {
                return repositorio.Eliminar(libro);
            }
        }

        public static List<Entidades.Libro> GetList(Expression<Func<Entidades.Libro, bool>> criterioBusqueda)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Libro>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }

        /*
        public static List<Entidades.Libro> GetListId(int id)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Libro>())
            {
                return repositorio.GetList(L => L.LibroId == id);
            }
        }

        public static List<Entidades.Libro> GetListTitulo(string titulo)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Libro>())
            {
                return repositorio.GetList(L => L.Titulo == titulo);
            }
        }*/

        public static List<Entidades.Libro> GetListEditorial(string nombreEditorial)
        {
            Entidades.Editorial editorial = null;
            List<Entidades.Editorial> lista = EditorialBLL.GetList(E => E.Nombre == nombreEditorial);
            if (lista.Count > 0)
            {
                editorial = lista.ElementAt(0);
            }
            if (editorial != null)
            {
                using (var repositorio = new DAL.Repositorio<Entidades.Libro>())
                {
                    return repositorio.GetList(L => L.EditorialId == editorial.EditorialId);

                }
            }
            else
            {
                return new List<Entidades.Libro>();
            }
                
        }

    }
}
