using System;
using System.Collections.Generic;

namespace LanInvoice.API.Models
{
    public class ShoppingList
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public virtual List<ShoppingListItemDto> ShoppingListItems { get; set; }
        public decimal Amount { get; set; }

    }
}