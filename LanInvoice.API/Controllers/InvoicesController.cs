using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LanInvoice.API.Controllers
{
    [Route("api/invoices")]
    public class InvoicesController : Controller
    {
        [HttpGet()]
        public IActionResult GetInvoices()
        {
            return new JsonResult(InvoicesDataStore.Current.Invoices);
        }

        [HttpGet("{id}")]
        public IActionResult GetInvoice(int id)
        {
            var invoiceToReturn = InvoicesDataStore.Current.Invoices.FirstOrDefault(i => i.Id == id);
            if (invoiceToReturn == null)
            {
                return NotFound();
            }

            return Ok(invoiceToReturn);
        }
    }
}
