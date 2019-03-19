using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LanInvoice.API.Entities
{
  public class LanPartyContext : DbContext
  {
    public DbSet<LanParty> LanParties { get; set; }
    public DbSet<Invoice> Invoices { get; set; }

    public LanPartyContext(DbContextOptions<LanPartyContext> options) : base(options)
    {
      Database.EnsureCreated();

    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //  optionsBuilder.UseSqlServer("connectionString");
    //  base.OnConfiguring(optionsBuilder);
    //}
  }
}
