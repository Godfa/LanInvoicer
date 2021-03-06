﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LanInvoice.API.Entities
{
  public class Invoice
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    public string Description { get; set; }
    public virtual List<ExpenseItem> ExpenseItems { get; set; }
    [ForeignKey("LanPartyId")]
    public LanParty LanParty { get; set; } 
    public int LanPartyId { get; set; }
  }
}
