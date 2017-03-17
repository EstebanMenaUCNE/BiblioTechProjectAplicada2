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
                throw;
                return null;                
            }
        }

        public TEntity Modificar(TEntity entidad)
        {
            try
            {
                EntitySet.Attach(entidad);
                Context.Entry<TEntity>(entidad).State = EntityState.Modified;
                Context.SaveChanges();
                return entidad;
            }
            catch (Exception)
            {
                throw;
                return null;
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
                throw;
                return false;
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
                throw;
                return null;
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> criterioBusqueda)
        {
            try
            {
                return EntitySet.Where(criterioBusqueda).ToList();
            }
            catch (Exception)
            {
                throw;
                return new List<TEntity>();                
            }
        }

        public void Dispose()
        {
            if (Context != null)
                Context.Dispose();
        }

    }
}
