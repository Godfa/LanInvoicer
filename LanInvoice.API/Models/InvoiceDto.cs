using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LanInvoice.API.Models
{
    public class InvoiceDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public virtual List<ExpenseItemDto> ExpenseItems { get; set; }
        public int LanPartyId { get; set; }

    }
}

