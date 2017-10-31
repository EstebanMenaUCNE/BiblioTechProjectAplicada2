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
        public static bool Guardar(Entidades.Libro libro, List<Entidades.AutorLibro> listaRelaciones, bool relacionesEliminadas)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Libro>())
            {
                bool libroGuardado;
                bool relacionesGuardadas = false;
                if (Buscar(L => L.LibroId == libro.LibroId) == null)
                {
                    libroGuardado = repositorio.Guardar(libro);
                }
                else
                {
                    libroGuardado = repositorio.Modificar(libro);
                }
                if (libroGuardado)
                {
                    if (relacionesEliminadas)
                    {
                        List<Entidades.AutorLibro> listaRelacionesBorrar = AutorLibroBLL.GetList(R => R.LibroId == libro.LibroId);
                        foreach (var relacion in listaRelacionesBorrar)
                        {
                            AutorLibroBLL.Eliminar(relacion);
                        }
                    }
                    relacionesGuardadas = true;
                    if (listaRelaciones != null)  //Si es diferente de null, porque modifico el estado de los libros en el registro de prestamos pero paso null a la lista porque no quiero modificar las relaciones de los autores y los libros
                    {
                        foreach (var relacion in listaRelaciones)
                        {
                            relacion.LibroId = libro.LibroId;
                            if (!AutorLibroBLL.Guardar(relacion))
                            {
                                relacionesGuardadas = false;
                            }
                        }
                    }
                }
                return relacionesGuardadas;
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

        public static List<Entidades.Libro> GetListConNombresEditoriales(Expression<Func<Entidades.Libro, bool>> criterioBusqueda)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Libro>())
            {
                List<Entidades.Libro> libros = repositorio.GetList(criterioBusqueda);
                foreach (var libro in libros)
                {
                    libro.NombreEditorial = EditorialBLL.Buscar(E => E.EditorialId == libro.EditorialId).Nombre;
                }
                return libros;
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
