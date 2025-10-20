using ClubManegment.DB;
using ClubManegment.Models;
using Microsoft.EntityFrameworkCore;

namespace ClubManegment.Repository.PlayerReposi
{
    public class PlayerRepo : GenericRepo<Player>, IPlayer
    {
        public PlayerRepo(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Team>> GetPlayersAsync()
        {
            return await _context.teams.Include(x=> x.Players).ToListAsync();
        }
    }
}
