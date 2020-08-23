using System;

namespace SOT.Abfs.RefereeTools.Models
{
    public class HallsInformation
    {
        public DateTime LastUpdate { get; set; }
        public HallModel[] Halls { get; set; }
    }
}