using System;
using System.Collections.Generic;

namespace LanInvoice.API.Models
{
  public class LanPartyDto
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int LanNumber { get; set; }
    public virtual List<UserDto> LanParticipants { get; set; }
    public ICollection<InvoiceDto> Invoices { get; } = new List<InvoiceDto>();

    public int InvoiceCount
    {
      get { return Invoices.Count; }
    }
  }
}