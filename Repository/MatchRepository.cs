using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class MatchRepository : RepositoryBase<Match>, IMatchRepository
    {
        public MatchRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }
        public async Task<IEnumerable<Match>> GetAllMatchesAsync(bool trackChanges) =>
             await FindAll(trackChanges).OrderBy(e => e.Id).ToListAsync();

#pragma warning disable CS8603 // Possible null reference return.
        public async Task<Match> GetMatchByIdAsync(int id, bool trackChanges) =>
             await FindByCondition(e => e.Id.Equals(id), trackChanges).SingleOrDefaultAsync();
#pragma warning restore CS8603 // Possible null reference return.
        public void CreateMatch(Match match)
        {
            CreateMatch(match);
        }
        public void DeleteMatch(Match match) => Delete(match);
    }
}
