using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BiblioTechProject.DAL
{
    public class Repositorio<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private BiblioTechDb Context;
        private DbSet<TEntity> EntitySet
        {
            get
            {
                return Context.Set<TEntity>();
            }
        }

        public Repositorio()
        {
            Context = new BiblioTechDb();
        }


        public TEntity Guardar(TEntity entidad)
        {
            try
            {
                EntitySet.Add(entidad);
                Context.SaveChanges();
                return entidad;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public bool Modificar(TEntity entidad)
        {
            try
            {
                EntitySet.Attach(entidad);
                Context.Entry<TEntity>(entidad).State = EntityState.Modified;
                return Context.SaveChanges() > 0; // revisar lineaaaaaa sino modificaaaaaaaaaaaa
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Eliminar(TEntity entidad)
        {
            try
            {
                EntitySet.Attach(entidad);
                EntitySet.Remove(entidad);
                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }


        public TEntity Buscar(Expression<Func<TEntity, bool>> criterioBusqueda)
        {
            try
            {
                return EntitySet.FirstOrDefault(criterioBusqueda);
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public List<TEntity> Lista(Expression<Func<TEntity, bool>> criterioBusqueda)
        {
            try
            {
                return EntitySet.Where(criterioBusqueda).ToList();
            }
            catch (Exception)
            {
                return new List<TEntity>();
                throw;
            }
        }

        public void Dispose()
        {
            if (Context != null)
                Context.Dispose();
        }

    }
}
