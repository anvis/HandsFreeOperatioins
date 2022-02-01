using AutoMapper;
using DataAccessLayer.Entities;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
  class AutoMapping  : Profile
  {
    public AutoMapping()
    {
      CreateMap<Handsonn, Prep>();    
    }

    private MapperConfiguration GetMapperConfiguration()
    {
      var config = new MapperConfiguration(cfg => {
        cfg.CreateMap<Handsonn, Prep>();
      });
      return config;
    }

    //anv try to use auto mapper with out making object in service layer.
    public IMapper GetMapper()
    {
      return GetMapperConfiguration().CreateMapper();
    }
  }
}
