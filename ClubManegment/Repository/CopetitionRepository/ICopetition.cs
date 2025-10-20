using ClubManegment.Models;

namespace ClubManegment.Repository.CopetitionRepository
{
    public interface ICopetition : IGeneric<Competition>
    {
        Task <IEnumerable<Competition>> GetAllcompeAsync ();
    }
}
