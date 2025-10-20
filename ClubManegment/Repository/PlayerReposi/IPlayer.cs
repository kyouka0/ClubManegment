using ClubManegment.Models;

namespace ClubManegment.Repository.PlayerReposi
{
    public interface IPlayer : IGeneric<Player>
    {
        Task <IEnumerable<Team>> GetPlayersAsync ();
    }
}
