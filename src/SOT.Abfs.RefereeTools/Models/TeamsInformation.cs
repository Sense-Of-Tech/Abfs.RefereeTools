using System;

namespace SOT.Abfs.RefereeTools.Models
{

    public class TeamsInformation
    {
        public DateTime LastUpdate { get; set; }
        public Team[] Teams { get; set; }
    }

}