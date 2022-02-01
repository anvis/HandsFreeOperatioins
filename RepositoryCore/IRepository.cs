using System;
using System.Collections.Generic;

namespace RepositoryCore
{
  // anvi change it to internal if possible..
  public interface IRepository<T>
  {
    List<T> GetAll();
    T GetById(int ID);
    void Insert(T t);
    void Update(T t);
    void Delete(T t);
    void Save(T t);
    bool SaveAllChanges();

  }
}
