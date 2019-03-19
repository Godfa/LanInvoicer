using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanInvoice.API.Entities
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
