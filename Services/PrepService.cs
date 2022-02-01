using System;
using System.Collections.Generic;
using DataAccessLayer.Entities;
using EntityLayer;
using Repository;

namespace Services
{
  public class PrepService
  {
    private IPrepRepository _PrepRepository;
    AutoMapping autoMapping = new AutoMapping();

    public PrepService(IPrepRepository repository)
    {
      _PrepRepository = repository;
    }


    public List<Prep> GetPreps()
    {
      
      var x = _PrepRepository.GetPreps();

      List<Prep>  preps = autoMapping.GetMapper().Map < List< Handsonn>, List< Prep >> (x);

      return preps;
    }
  }
}
