using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BiblioTechProject.BLL
{
    public class ClienteBLL
    {
        public static bool Guardar(Entidades.Cliente cliente)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Cliente>())
            {
                if (Buscar(C => C.ClienteId == cliente.ClienteId) == null)
                {
                    return repositorio.Guardar(cliente);
                }
                else
                {
                    return repositorio.Modificar(cliente);
                }
            }
        }

        public static Entidades.Cliente Buscar(Expression<Func<Entidades.Cliente, bool>> criterioBusqueda)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Cliente>())
            {
                return repositorio.Buscar(criterioBusqueda);
            }
        }

        public static bool Eliminar(Entidades.Cliente cliente)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Cliente>())
            {
                bool prestamosElimiados = true;
                List<Entidades.Prestamo> listaPrestamos = PrestamoBLL.GetList(P => P.ClienteId == cliente.ClienteId);
                foreach (var prestamo in listaPrestamos)
                {
                    if (!PrestamoBLL.Eliminar(prestamo))
                    {
                        prestamosElimiados = false;
                    }
                }
                if (prestamosElimiados)
                {
                    return repositorio.Eliminar(cliente);
                }
                return false;
            }
        }

        public static List<Entidades.Cliente> GetList(Expression<Func<Entidades.Cliente, bool>> criterioBusqueda)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Cliente>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }
        /*
        public static List<Entidades.Cliente> GetListId(int id)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Cliente>())
            {
                return repositorio.GetList(C => C.ClienteId == id);
            }
        }

        public static List<Entidades.Cliente> GetListNombre(string nombre)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Cliente>())
            {
                return repositorio.GetList(C => C.Nombre == nombre);
            }
        }

        public static List<Entidades.Cliente> GetListCedula(string cedula)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Cliente>())
            {
                return repositorio.GetList(C => C.Cedula == cedula);
            }
        }

        public static List<Entidades.Cliente> GetListTelefono(string telefono)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Cliente>())
            {
                return repositorio.GetList(C => C.Telefono == telefono);
            }
        }

        public static List<Entidades.Cliente> GetListEmail(string email)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Cliente>())
            {
                return repositorio.GetList(C => C.Email == email);
            }
        }
        */
    }
}
