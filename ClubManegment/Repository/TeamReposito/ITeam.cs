using ClubManegment.Models;

namespace ClubManegment.Repository.TeamReposito
{
    public interface ITeam : IGeneric<Team>
    {
        Task <IEnumerable<Team>> GetTeamsAsync ();
    }
}
