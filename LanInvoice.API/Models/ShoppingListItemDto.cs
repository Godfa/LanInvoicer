using System;

namespace LanInvoice.API.Models
{
    public class ShoppingListItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }
        public virtual ShoppingList ShoppingList { get; set; }

    }
}