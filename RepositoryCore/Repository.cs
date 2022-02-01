using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace RepositoryCore
{
  public class Repository<T> : IRepository<T> where T : class
  {
    private DbSet<T> _dbset;
    private readonly DbContext HandsfreeContext;

    public Repository()
    { 
    }

    public Repository(DbContext context)
    {
      HandsfreeContext = context;
      _dbset = context.Set<T>();
    }

    public void Delete(T t)
    {
      _dbset.Remove(t);
    //  throw new NotImplementedException();
    }

    public List<T> GetAll()
    {
      return _dbset.ToList();
    }

    public T GetById(int ID)
    {
      return _dbset.Find(ID);
    //  throw new NotImplementedException();
    }

    public void Insert(T entity)
    {
      if (entity == null)
        throw new ArgumentNullException("entity");

      _dbset.Add(entity);
      HandsfreeContext.SaveChanges();

    }

    public void Save(T t)
    {
      _dbset.Add(t);
    }

    public void Update(T t)
    {
     // HandsfreeContext.Entry(t).State = EntityState.Modified;
      _dbset.Attach(t);

    }

    public bool SaveAllChanges()
    {
      HandsfreeContext.SaveChanges();
      return true;
    }
  }
}
