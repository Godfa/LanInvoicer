using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanInvoice.API.Entities;

namespace LanInvoice.API.Controllers
{
  public class DummyController : Controller
  {
    private LanPartyContext _ctx;

    public DummyController(LanPartyContext ctx)
    {
      _ctx = ctx;
    }

    [HttpGet]
    [Route("api/testdatabase")]
    public IActionResult TestDatabase()
    {
      return Ok();
    }
  }
}
