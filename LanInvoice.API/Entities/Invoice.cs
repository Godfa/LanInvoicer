using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LanInvoice.API.Entities
{
  public class Invoice
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public virtual List<ExpenseItem> ExpenseItems { get; set; }
    public int LanPartyId { get; set; }
  }
}
