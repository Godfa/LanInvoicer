using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LanInvoice.API.Controllers
{
  [Route("api/lanparties")]
  public class LanPartiesController : Controller
  {
    [HttpGet()]
    public IActionResult GetLanParties()
    {
      return new JsonResult(LanPartiesDataStore.Current.LanParties);
    }

    [HttpGet("{lanPartyId}")]
    public IActionResult GetLanParty(int lanPartyId)
    {
      var lanPartyToReturn = LanPartiesDataStore.Current.LanParties.FirstOrDefault(i =>  i.Id == lanPartyId);
      if (lanPartyToReturn == null)
      {
        return NotFound();
      }
      return Ok(lanPartyToReturn);
    }
  }
}
