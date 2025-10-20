using ClubManegment.Models;

namespace ClubManegment.DTO
{
    public class ReadTeams
    {
        public string Title { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;

        public List<MyClass>? Playersdto { get; set; }
    }
    public class MyClass
    {
        public string FullName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string position { get; set; } = string.Empty;
    }
}
