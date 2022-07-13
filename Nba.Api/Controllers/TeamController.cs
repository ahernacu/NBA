using Microsoft.AspNetCore.Mvc;
using Nba.Services.Interfaces;

namespace Nba.Api.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]

    public class TeamController : ControllerBase
    {
        private readonly ITeamService _teamService;
        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet("{teamId}")]
        public async Task<IActionResult> Get([FromRoute] int teamId)
        {
            var team = await _teamService.GetTeamAsync(teamId);

            return Ok(team);
        }
    }
}