using System;
using System.Collections.Generic;

namespace LanInvoice.API.Models
{
    public class ExpenseItemDto        
    {
        public int Id { get; set; }
        public int InvoiceGuid { get; set; }
        public virtual List<UserDto> ExpenseDebitors { get; set; }
        public int ExpenseCreditor { get; set; }
        public ExpenseTypeDto ExpenseType { get; set; }
    }
}