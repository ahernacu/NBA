using Microsoft.AspNetCore.Mvc;
using Nba.Services.Implementations;

namespace Nba.Api.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        PlayerService playerService;

        [HttpGet]
        public async Task<IActionResult> Get([FromRoute] int playerId)
        {
            return Ok();
        }
    }
}