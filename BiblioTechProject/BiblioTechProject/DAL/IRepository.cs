﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BiblioTechProject.DAL
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Guardar(TEntity entidad);
        bool Modificar(TEntity entidad);
        bool Eliminar(TEntity entidad);
        TEntity Buscar(Expression<Func<TEntity, bool>> criterioBusqueda);
        List<TEntity> Lista(Expression<Func<TEntity, bool>> criterioBusqueda);
    }

}
