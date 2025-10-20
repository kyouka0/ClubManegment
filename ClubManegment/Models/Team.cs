namespace ClubManegment.Models
{
    public class Team
    {

        public int TeamId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;

         
        public int CoachId { get; set; } 

        public Coach? Coach { get; set; }
        public List<Player> ?Players { get; set; }
        public List<Competition>? Competition { get; set; }



    }
}
