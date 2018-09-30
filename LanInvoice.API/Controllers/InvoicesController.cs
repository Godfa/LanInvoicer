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
        public JsonResult GetInvoices()
        {
            return new JsonResult(new List<object>()
            {
                new { id = 1, Number="60"}, 
                new { id = 2, Number="61"}
            });
        }
    }
}
