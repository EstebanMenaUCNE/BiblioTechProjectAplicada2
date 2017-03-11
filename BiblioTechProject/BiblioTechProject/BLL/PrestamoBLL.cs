using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblioTechProject.BLL
{
    public class PrestamoBLL
    {
        public static bool Guardar(Entidades.Prestamo prestamo)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Prestamo>())
            {
                if (repositorio.Buscar(P => P.PrestamoId == prestamo.PrestamoId) == null)
                {
                    return repositorio.Guardar(prestamo) != null;
                }
                else
                {
                    return repositorio.Modificar(prestamo);
                }
            }
        }

        public static Entidades.Prestamo Buscar(Entidades.Prestamo prestamo)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Prestamo>())
            {
                return repositorio.Buscar(P => P.PrestamoId == prestamo.PrestamoId);
            }
        }

        public static bool Eliminar(Entidades.Prestamo prestamo)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Prestamo>())
            {
                return repositorio.Eliminar(prestamo);
            }
        }

        public static List<Entidades.Prestamo> GetList()
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Prestamo>())
            {
                return repositorio.GetList(P => P.PrestamoId > 0);
            }
        }

        public static List<Entidades.Prestamo> GetListId(int id)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Prestamo>())
            {
                return repositorio.GetList(P => P.PrestamoId == id);
            }
        }

        public static List<Entidades.Prestamo> GetListCliente(string nombreCliente)
        {
            Entidades.Cliente cliente = ClienteBLL.GetListNombre(nombreCliente).ElementAt(0);
            if (cliente != null)
            {
                using (var repositorio = new DAL.Repositorio<Entidades.Prestamo>())
                {
                    return repositorio.GetList(P => P.ClienteId == cliente.ClienteId);
                }
            }
            else
            {
                return new List<Entidades.Prestamo>();
            }

        }

    }
}
