using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BiblioTechProject.BLL
{
    public class DevolucionBLL
    {
        public static bool Guardar(Entidades.Devolucion devolucion)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Devolucion>())
            {
                if (Buscar(D => D.DevolucionId == devolucion.DevolucionId) == null)
                {
                    return repositorio.Guardar(devolucion) != null;
                }
                else
                {
                    return repositorio.Modificar(devolucion);
                }
            }
        }

        public static Entidades.Devolucion Buscar(Expression<Func<Entidades.Devolucion, bool>> criterioBusqueda)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Devolucion>())
            {
                return repositorio.Buscar(criterioBusqueda);
            }
        }

        public static bool Eliminar(Entidades.Devolucion devolucion)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Devolucion>())
            {
                return repositorio.Eliminar(devolucion);
            }
        }

        public static List<Entidades.Devolucion> GetList(Expression<Func<Entidades.Devolucion, bool>> criterioBusqueda)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Devolucion>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }

        /*public static List<Entidades.Devolucion> GetListId(int id)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Devolucion>())
            {
                return repositorio.GetList(D => D.DevolucionId == id);
            }
        }
        */

        public static List<Entidades.Devolucion> GetListCliente(string nombreCliente)
        {
            Entidades.Cliente cliente = null;
            List<Entidades.Cliente> lista = ClienteBLL.GetList(C => C.Nombre == nombreCliente);
            if (lista.Count > 0)
            {
                cliente = lista.ElementAt(0);
            }
            if(cliente != null)
            {
                using (var repositorio = new DAL.Repositorio<Entidades.Devolucion>())
                {
                    return repositorio.GetList(D => D.ClienteId == cliente.ClienteId);
                }
            }
            else
            {
                return new List<Entidades.Devolucion>();
            }
            
        }

    }
}
