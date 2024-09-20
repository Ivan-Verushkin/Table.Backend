using Table.Project.Models;

namespace Table.Project.Repository.IRepository
{
    public interface ISoccererRepository
    {
        Task<List<FifaSoccerer>> GetAll();
        Task<FifaSoccerer> Get(int id);
        IQueryable<FifaSoccerer> GetAllFifaPlayersAsQuery();
    }
}
