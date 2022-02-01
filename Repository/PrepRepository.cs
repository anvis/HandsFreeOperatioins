using EntityLayer;
using RepositoryCore;
using System;
using System.Collections.Generic;
using DataAccessLayer;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
  public class PrepRepository : Repository<PrepRepository> , IPrepRepository
  {
    private IRepository<Handsonn> _PrepsRepository;
    private DbContext db = null;

    public HandsfreeContext context
    {
      get
      {
        return db as HandsfreeContext;
      }
    }

    public PrepRepository()
    {
      _PrepsRepository = new Repository<Handsonn>(new HandsfreeContext());
    }

    public PrepRepository(DbContext _db) : base(_db) // : base(db)
    {
      _PrepsRepository = new Repository<Handsonn>(new HandsfreeContext());
    }


    public List<Handsonn> GetPreps()
    {
     return  _PrepsRepository.GetAll();      
    }
  }
}
