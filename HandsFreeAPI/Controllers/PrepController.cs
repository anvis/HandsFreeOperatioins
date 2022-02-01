using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryFactory;
using Services;

namespace HandsFreeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrepController : ControllerBase
    {

    // anvi this controller is not calling..

    [HttpGet]
    public ActionResult<IEnumerable<Prep>> Get()
    {
      // anvi use  Registry.GetRepository<IOnOrderService>(uow); pattern here..
      PrepService ps = new PrepService(Repo.GetPrepRepository());
     return ps.GetPreps();

      //return new string[] { "value1", "value2" };
    }


  }
}