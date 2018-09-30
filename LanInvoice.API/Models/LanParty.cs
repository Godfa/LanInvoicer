using System;
using System.Collections.Generic;

namespace LanInvoice.API.Models
{
    public class LanParty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<User> LanParticipants { get; set; }
    }
}