using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblioTechProject.BLL
{
    public class ClienteBLL
    {
        public static bool Guardar(Entidades.Cliente cliente)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Cliente>())
            {
                if (repositorio.Buscar(C => C.ClienteId == cliente.ClienteId) == null)
                {
                    return repositorio.Guardar(cliente) != null;
                }
                else
                {
                    return repositorio.Modificar(cliente);
                }
            }
        }

        public static Entidades.Cliente Buscar(Entidades.Cliente cliente)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Cliente>())
            {
                return repositorio.Buscar(C => C.ClienteId == cliente.ClienteId);
            }
        }

        public static bool Eliminar(Entidades.Cliente cliente)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Cliente>())
            {
                return repositorio.Eliminar(cliente);
            }
        }

        public static List<Entidades.Cliente> GetList()
        {
            using (var repositorio = new DAL.Repositorio<Entidades.Cliente>())
            {
                return repositorio.GetList(C => C.ClienteId > 0);
            }
        }

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

    }
}
