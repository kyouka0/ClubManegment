namespace ClubManegment.Models
{
    public class Coach
    {
        public int CoachId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string  specialyzation { get; set; } = string.Empty;
        public int Experience { get; set; } 
        public Team? Team { get; set; }

    }
}
