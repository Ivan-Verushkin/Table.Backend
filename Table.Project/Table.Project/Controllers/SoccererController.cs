using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Table.Project.Models;
using Table.Project.Repository.IRepository;

namespace Table.Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoccererController : ControllerBase
    {
        private ISoccererRepository _soccererRepository;

        public SoccererController(ISoccererRepository _socRepository)
        {
            _soccererRepository = _socRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<FifaSoccerer>>> GetFifaPlayers() {
            var players = await _soccererRepository.GetAll();

            return Ok(players.ToList());
        }
    }
}
