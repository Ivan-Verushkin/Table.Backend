using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        [Route("all")]
        public async Task<ActionResult<List<FifaSoccerer>>> GetFifaPlayers() {
            var players = await _soccererRepository.GetAll();

            return Ok(players.ToList());
        }

        [HttpGet]
        public async Task<ActionResult<List<FifaSoccerer>>> GetFilteredFifaPlayers(
            int pageNumber = 1, 
            int pageSize = 10, 
            string sortColumn = "name",
            string sortDirection = "asc",
            string searchItem = "")
        {
            var query = _soccererRepository.GetAllFifaPlayersAsQuery();

            if (!string.IsNullOrEmpty(searchItem))
            {
                query = query.Where(a => a.Name.Contains(searchItem) ||
                                    a.Position.Contains(searchItem) ||
                                    a.Skill.Contains(searchItem));
            }

            //Apply sorting
            switch (sortColumn.ToLower())
            {
                case "age":
                    {
                        query = sortDirection == "asc" ? query.OrderBy(a => a.Age) : query.OrderByDescending(a => a.Age);
                        break;
                    }
                case "skill":
                    {
                        query = sortDirection == "asc" ? query.OrderBy(a => a.Skill) : query.OrderByDescending(a => a.Skill);
                        break;
                    }
                case "position":
                    {
                        query = sortDirection == "asc" ? query.OrderBy(a => a.Position) : query.OrderByDescending(a => a.Position);
                        break;
                    }
                case "score":
                    {
                        query = sortDirection == "asc" ? query.OrderBy(a => a.Score) : query.OrderByDescending(a => a.Score);
                        break;
                    }
                default: 
                    {
                        query = sortDirection == "asc" ? query.OrderBy(a => a.Name) : query.OrderByDescending(a => a.Name);
                        break;
                    }
            }

            //Apply pagination
            var totalRecords = await query.CountAsync();
            var athlets = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return Ok(new
            {
                Data = athlets,
                TotalRecords = totalRecords,
                PageNumber = pageNumber,
                PageSize = pageSize
            });
        }
    }
}
