using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BiblioTechProject.BLL
{
    public class LibroBLL
    {
        public static Entidades.Libro Guardar(Entidades.Libro libro)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Libro>())
            {
                if (Buscar(L => L.LibroId == libro.LibroId) == null)
                {
                    return repositorio.Guardar(libro);
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
                bool relacionesEliminadas = true;
                List<Entidades.AutorLibro> listaRelacionesAutores = AutorLibroBLL.GetList(R => R.LibroId == libro.LibroId);
                foreach (var relacion in listaRelacionesAutores)
                {
                    if (!AutorLibroBLL.Eliminar(relacion))
                    {
                        relacionesEliminadas = false;
                    }
                }
                List<Entidades.PrestamoLibro> listaRelacionesPrestamos = PrestamoLibroBLL.GetList(R => R.LibroId == libro.LibroId);
                foreach (var relacion in listaRelacionesPrestamos)
                {
                    if (!PrestamoLibroBLL.Eliminar(relacion))
                    {
                        relacionesEliminadas = false;
                    }
                }
                if (relacionesEliminadas)
                {
                    return repositorio.Eliminar(libro);
                }
                return false;
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
        }
        */

    }
}
