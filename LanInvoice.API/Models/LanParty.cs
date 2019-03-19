using System;
using System.Collections.Generic;

namespace LanInvoice.API.Models
{
  public class LanParty
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int LanNumber { get; set; }
    public virtual List<User> LanParticipants { get; set; }
    public ICollection<Invoice> Invoices { get; } = new List<Invoice>();

    public int InvoiceCount
    {
      get { return Invoices.Count; }
    }
  }
}