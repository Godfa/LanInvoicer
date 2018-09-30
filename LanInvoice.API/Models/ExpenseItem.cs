using System;
using System.Collections.Generic;

namespace LanInvoice.API.Models
{
    public class ExpenseItem        
    {
        public int Id { get; set; }
        public int InvoiceGuid { get; set; }
        public virtual List<User> ExpenseDebitors { get; set; }
        public int ExpenseCreditor { get; set; }
        public ExpenseType ExpenseType { get; set; }
    }
}