using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using EZ.MvcDotNet.Domain.Interfaces.Repository;
using EZ.MvcDotNet.Infra.Data.Context;
using EZ.MvcDotNet.Infra.Data.Interfaces;
using Microsoft.Practices.ServiceLocation;

namespace EZ.MvcDotNet.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected MvcDotNetContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository()
        {
            var contextManager = ServiceLocator.Current.GetInstance<IContextManager>();
            Db = contextManager.GetContext();
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Adicionar(TEntity obj)
        {
            DbSet.Add(obj);
            //SaveChanges();
        }

        public virtual TEntity ObterPorId(Guid id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> ObterTodos()
        {
            return DbSet.ToList();
        }

        /*
         * com paginação
            public virtual IEnumerable<TEntity> ObterTodos(int skip, int take)
            {
                return DbSet.ToList().Skip(skip).Take(take);
            }
             */

        public virtual void Atualizar(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified; // encontra as diferenças do objeto
            //SaveChanges();
        }

        public virtual void Remover(Guid id)
        {
            DbSet.Remove(ObterPorId(id));
            //SaveChanges();
        }

        public virtual IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this); // Encerra/elimina da memória assim que deixa de ser utilizado
        }
    }
}