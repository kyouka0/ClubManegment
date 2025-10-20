using ClubManegment.DTO;
using ClubManegment.Repository.PlayerReposi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClubManegment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayer _Player;

        public PlayerController(IPlayer player)
        {
            _Player = player;
        }
        [HttpGet]
        public async Task<IActionResult> GetYoungest()
        {
            var e = await _Player.GetPlayersAsync();
            var te = e.Select(x => new ReadTeam
            {
                
                TeamId = x.TeamId,
                Title = x.Title,
                City = x.City,

                //  ReadPlayers = x.Players.OrderBy(q => q.Age).Take(1).Select(z => new ReadPlayer 

                ReadPlayers = x.Players.Where(a=> a.Age == x.Players.Min(c=> c.Age)).Select(z => new ReadPlayer
                {

                    PlayerId = z.PlayerId,
                    FullName = z.FullName,
                    Age = z.Age,
                    position = z.position
                    
                }).ToList(),

            }).ToList();
            var Teams = te.GroupBy(z => z.Title).Select(x => new
            {
                Title = x.Key,
                Teams = x.ToList(),
            });
            return Ok(Teams);
        }
    }
}
