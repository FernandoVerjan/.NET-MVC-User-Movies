using BusinessLogic.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected MoviesContext MoviesContext;
        public RepositoryBase(MoviesContext repositoryContext)
        {
            MoviesContext = repositoryContext;
        }

        public IQueryable<T> FindAll(bool trackChanges) => !trackChanges ? MoviesContext.Set<T>().AsNoTracking() : MoviesContext.Set<T>();
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression,
        bool trackChanges) =>
        !trackChanges ?
        MoviesContext.Set<T>()
        .Where(expression)
        .AsNoTracking() :
        MoviesContext.Set<T>()
        .Where(expression);
        public void Create(T entity) => MoviesContext.Set<T>().Add(entity);
        public void Update(T entity) => MoviesContext.Set<T>().Update(entity);
        public void Delete(T entity) => MoviesContext.Set<T>().Remove(entity);
    }
}
