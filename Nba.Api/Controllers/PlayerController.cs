using Microsoft.AspNetCore.Mvc;
using Nba.Services.Interfaces;

namespace Nba.Api.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
       private readonly IPlayerService _playerService;
        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet("{playerId}")]
        public async Task<IActionResult> Get([FromRoute] int playerId)
        {
            var player = await _playerService.GetPlayerAsync(playerId);

            return Ok(player);
        }
    }
}