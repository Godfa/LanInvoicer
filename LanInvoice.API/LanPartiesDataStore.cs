using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanInvoice.API.Models;

namespace LanInvoice.API
{
  public class LanPartiesDataStore
  {
    public static LanPartiesDataStore Current { get; } = new LanPartiesDataStore();
    public List<LanParty> LanParties { get; set; }

    public LanPartiesDataStore()
    {
      LanParties = new List<LanParty>()
      {
        new LanParty()
        {
          Id = 1,
          Name = "Best LAN ever",
          LanNumber = 50,
          LanParticipants = new List<User>()
          {
            new User()
            {
              UserName = "Epi",
              Id = 1,
              Email = "epituo@gmail.com",
              Password = "overlord",
              UserRole = (int) RoleType.Admin
            }
          }

        }
      };



    }



  }
}
