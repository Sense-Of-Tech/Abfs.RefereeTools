namespace SOT.Abfs.RefereeTools.Models
{
    public class Team
    {
        public string Division { get; set; }
        public int Matricule { get; set; }
        public string ClubName { get; set; }
        public string Hall { get; set; }
        public int HallId { get; set; }
        public int Bloc1 { get; set; }
        public int Bloc2 { get; set; }
        public int Hour { get; set; }
        public int? Difference { get; set; }
        public string SearchString => $"{Division}|{Matricule}|{ClubName}|{Hall}|{HallId}|{Bloc1}{Bloc2}|{Hour}|{Bloc1}-{Bloc2}";
    }
}
