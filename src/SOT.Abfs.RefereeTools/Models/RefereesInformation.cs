using System;

namespace SOT.Abfs.RefereeTools.Models
{
    public class RefereesInformation
    {
        public DateTime LastUpdate { get; set; }
        public Referee[] Referees { get; set; }
    }
}