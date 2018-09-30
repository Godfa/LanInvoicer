using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LanInvoice.API.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public virtual List<ExpenseItem> ExpenseItems { get; set; }
        public virtual LanParty LanPartyId { get; set; }

    }
}

