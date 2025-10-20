namespace ClubManegment.DTO
{
    public class ReadAllCompt
    {
        public int CompetitionId { get; set; }
        public string CompetitionName { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public DateOnly Date { get; set; }
        public int Totalcocunt {  get; set; }
    }
}
