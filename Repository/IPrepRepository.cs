using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Entities;
using RepositoryCore;

namespace Repository
{
  public interface IPrepRepository : IRepository<PrepRepository>
  {
    List<Handsonn> GetPreps();
  }
}
