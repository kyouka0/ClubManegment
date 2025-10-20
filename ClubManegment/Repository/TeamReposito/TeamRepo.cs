using ClubManegment.DB;
using ClubManegment.Models;
using Microsoft.EntityFrameworkCore;

namespace ClubManegment.Repository.TeamReposito
{
    public class TeamRepo : GenericRepo<Team>, ITeam
    {
        public TeamRepo(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Team>> GetTeamsAsync()
        {
            return await _context.teams.Where(x => !x.Competition.Any()).Include(x=> x.Players).ToListAsync();

        }
    }
}
