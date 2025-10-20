using ClubManegment.DB;
using ClubManegment.Models;
using Microsoft.EntityFrameworkCore;

namespace ClubManegment.Repository.CopetitionRepository
{
    public class CopetitionRepo : GenericRepo<Competition>, ICopetition
    {
        public CopetitionRepo(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Competition>> GetAllcompeAsync()
        {
            return await _context.competitions.ToListAsync();
        }
    }
}
