using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LanInvoice.API.Entities
{
  public class LanParty
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [MaxLength(50)]
    public string Name { get; set; }
    [MaxLength(140)]
    public string Description { get; set; }
    [Required]
    public int LanNumber { get; set; }
    public virtual List<User> LanParticipants { get; set; }
    public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
  }
}
 