using FCM.Data.Entities.Abstract_Classes;
using System;
using System.Collections.Generic;

namespace FCM.Data.Entities
{
    public class Club : BaseEntity
    {
        public string ClubName { get; set; }
        public DateTime FoundingDate { get; set; }

        ICollection<Player> Players { get; set; }
    }
}
