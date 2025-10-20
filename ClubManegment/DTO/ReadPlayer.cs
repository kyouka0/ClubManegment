using ClubManegment.Models;

namespace ClubManegment.DTO
{
    public class ReadPlayer
    {
        public int PlayerId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string position { get; set; } = string.Empty;
      
    }
    public class ReadTeam
    {
        public int TeamId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;



        public List<ReadPlayer> ReadPlayers { get; set; }
    }
}
