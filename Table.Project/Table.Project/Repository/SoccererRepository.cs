using Microsoft.EntityFrameworkCore;
using Table.Project.Data;
using Table.Project.Models;
using Table.Project.Repository.IRepository;

namespace Table.Project.Repository
{
    public class SoccererRepository : ISoccererRepository
    {
        private readonly DataContext _context;
        public SoccererRepository(DataContext _context)
        {
            this._context = _context;
        }
        public async Task<List<FifaSoccerer>> GetAll()
        {
            return await _context.FifaSoccerers.ToListAsync();
        }
    }
}
