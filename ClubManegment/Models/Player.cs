namespace ClubManegment.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string position { get; set; }= string.Empty;
        public  int CoachId { get; set; } 

        public Coach ?Coach { get; set; }
        public Team? Team { get; set; }


    }
}
