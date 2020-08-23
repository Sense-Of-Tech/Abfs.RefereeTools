using System.Diagnostics;

namespace SOT.Abfs.RefereeTools.Models
{
    public class HallModel
    {
        public int Id { get; set; }
        public string HallName { get; set; }
        public string Street { get; set; }
        public int PostCode { get; set; }
        public string City { get; set; }
        public int Bloc1 { get; set; }
        public int Bloc2 { get; set; }
        public int? Difference { get; set; }
        public string SearchString => $"{Id}|{HallName}|{Street}|{City}|{PostCode}|{PostCode} {City}|{Bloc1}{Bloc2}|{Bloc1}-{Bloc2}";

        public string MapWhere => $"{HallName}, {Street}, {PostCode} {City}";
    }
}