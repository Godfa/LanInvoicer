using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanInvoice.API.Controllers
{
  [Route("api/lanparties")]
  public class InvoicesController : Controller
  {
    [HttpGet("{lanPartyId}/invoices")]
    public IActionResult GetInvoices(int lanPartyId)
    {
      return new JsonResult(InvoicesDataStore.Current.Invoices);
    }

    [HttpGet("{lanPartyId}/invoices/{invoiceId}")]
    public IActionResult GetInvoice(int lanPartyId, int invoiceId)
    {
      var invoiceToReturn = InvoicesDataStore.Current.Invoices.FirstOrDefault(i => i.Id == invoiceId && i.LanPartyId == lanPartyId);
      if (invoiceToReturn == null)
      {
        return NotFound();
      }
      return Ok(invoiceToReturn);
    }
  }
}
