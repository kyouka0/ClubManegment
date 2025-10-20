using ClubManegment.DTO;
using ClubManegment.Repository.TeamReposito;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClubManegment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeam _team;

        public TeamController(ITeam team)
        {
            _team = team;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
         var teams =await  _team.GetTeamsAsync();
            var teamsss = teams.Select(x=> new  ReadTeams 
            {
                  Title = x.Title,
                   City = x.City,
                    Playersdto = x.Players.Select(z=>  new MyClass
                    {
                         FullName = z.FullName,
                         Age = z.Age,
                          position = z.position
                    }).ToList(),
            }).ToList();
            return Ok(teamsss);
        }
    } 
}
