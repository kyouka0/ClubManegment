using ClubManegment.DTO;
using ClubManegment.Repository.CopetitionRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClubManegment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetController : ControllerBase
    {
        private readonly ICopetition _com;

        public CompetController(ICopetition com)
        {
            _com = com;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var e = await _com.GetAllcompeAsync();
            var cop = e.Select(x => new ReadAllCompt
            {
                CompetitionId = x.CompetitionId,
                CompetitionName = x.CompetitionName,
                Location = x.Location,
                Date = x.Date,
                Totalcocunt = x.Team != null ? x.Team.Sum(s => s.Players != null ? s.Players.Count() : 0) : 0
            }).ToList();
            return Ok(cop);
        }
    }
}
