using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Mikan.DAL
{
  public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
  {
    internal AgricultureContext context;
    internal DbSet<TEntity> dbSet;

    public BaseRepository(AgricultureContext context)
    {
      this.context = context;
      this.dbSet = context.Set<TEntity>();
    }

    public virtual IEnumerable<TEntity> GetWithRawSql(string query,
        params object[] parameters)
    {
      return dbSet.FromSqlRaw(query, parameters).ToList();
    }

    public virtual IEnumerable<TEntity> Get(
        Expression<Func<TEntity, bool>> filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        string includeProperties = "")
    {
      IQueryable<TEntity> query = dbSet;

      if (filter != null)
      {
        query = query.Where(filter);
      }

      if (includeProperties != null)
      {
        foreach (var includeProperty in includeProperties.Split
        (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        {
          query = query.Include(includeProperty);
        }
      }


      if (orderBy != null)
      {
        return orderBy(query).ToList();
      }
      else
      {
        return query.ToList();
      }
    }

    public virtual TEntity GetByID(object id)
    {
      return dbSet.Find(id);
    }

    public virtual void Insert(TEntity entity)
    {
      context.Entry(entity).State = EntityState.Modified;
      dbSet.Add(entity);
    }

    public void Detach(TEntity entity)
    {
      context.Entry(entity).State = EntityState.Detached;
    }

    public virtual void Delete(object id)
    {
      TEntity entityToDelete = dbSet.Find(id);
      Delete(entityToDelete);
    }

    public virtual void Delete(TEntity entityToDelete)
    {
      if (context.Entry(entityToDelete).State == EntityState.Detached)
      {
        dbSet.Attach(entityToDelete);
        context.Entry(entityToDelete).State = EntityState.Modified;
      }
      dbSet.Remove(entityToDelete);
      Save();
    }

    public virtual void Update(TEntity entityToUpdate)
    {
      //var entity = dbSet.Find(Id);
      //entity = entityToUpdate;
      context.Entry(entityToUpdate).State = EntityState.Modified;
      dbSet.Update(entityToUpdate);
    }

    public List<TEntity> GetAll()
    {
      return dbSet.ToList();
    }

    public void Save()
    {
      context.SaveChanges();
    }
  }
}
