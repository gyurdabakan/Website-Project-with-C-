using System;
using Microsoft.EntityFrameworkCore;
using WebSiteProject.Entity.Entities;
using WebSiteProject.Persistance.Repositories.IRepository;

namespace WebSiteProject.Persistance.Repositories
{
	public class EfBaseRepository<TEntity,TContext> : IAddableRepository<TEntity>, IDeletableRepository<TEntity>,
                                IUpdatableRepository<TEntity>, ISelectableRepository<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext
    {

        protected TContext _context { get; }

        public EfBaseRepository(TContext context)
        {
            _context = context;
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Entry(entity).State = EntityState.Deleted;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Entry(entity).State = EntityState.Added;
        }

        public TEntity Get(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}

