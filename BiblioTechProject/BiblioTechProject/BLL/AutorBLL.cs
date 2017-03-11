using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblioTechProject.BLL
{
    public class AutorBLL
    {
        public static bool Guardar(Entidades.Autor autor)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Autor>())
            {
                if (repositorio.Buscar(A => A.AutorId == autor.AutorId) == null)
                {
                    return repositorio.Guardar(autor) != null;
                }
                else
                {
                    return repositorio.Modificar(autor);
                }
            }
        }

        public static Entidades.Autor Buscar(Entidades.Autor autor)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Autor>())
            {
                return repositorio.Buscar(A => A.AutorId == autor.AutorId);
            }
        }

        public static bool Eliminar(Entidades.Autor autor)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Autor>())
            {
                return repositorio.Eliminar(autor);
            }
        }

        public static List<Entidades.Autor> GetList()
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Autor>())
            {
                return repositorio.GetList(A => A.AutorId > 0);
            }
        }

        public static List<Entidades.Autor> GetListNombre(string nombre)
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
        }
    }
}
