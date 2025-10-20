namespace ClubManegment.Models
{
    public class Competition
    {
        public int CompetitionId { get; set; }
        public string CompetitionName { get; set; } = string.Empty;
        public string Location { get; set;} = string.Empty;
        public DateOnly Date { get; set; } 
         
        public List<Team> ?Team { get; set; }





    }
}
