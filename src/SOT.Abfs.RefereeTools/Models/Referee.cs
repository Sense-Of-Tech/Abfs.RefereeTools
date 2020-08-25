namespace SOT.Abfs.RefereeTools.Models
{
    public class Referee
    {
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public int Bloc1{ get; set; }
        public int Bloc2 { get; set; }
        public override string ToString() => $"{Firstname} {Lastname} ({Bloc1}-{Bloc2})";
    }
}