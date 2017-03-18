using BiblioTechProject.DAL;
using BiblioTechProject.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class DevolucionLibroBLL
    {
        public static DevolucionLibro Guardar(DevolucionLibro devolucionLibro)
        {
            using (var repositorio = new Repositorio<DevolucionLibro>())
            {
                if (Buscar(A => A.Id == devolucionLibro.Id) == null)
                {
                    return repositorio.Guardar(devolucionLibro);
                }
                else
                {
                    return repositorio.Modificar(devolucionLibro);
                }
            }
        }

        public static DevolucionLibro Buscar(Expression<Func<DevolucionLibro, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<DevolucionLibro>())
            {
                return repositorio.Buscar(criterioBusqueda);
            }
        }

        public static bool Eliminar(DevolucionLibro devolucionLibro)
        {
            using (var repositorio = new Repositorio<DevolucionLibro>())
            {
                return repositorio.Eliminar(devolucionLibro);
            }
        }

        public static List<DevolucionLibro> GetList(Expression<Func<DevolucionLibro, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<DevolucionLibro>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }
    }
}
