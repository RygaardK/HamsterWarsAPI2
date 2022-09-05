using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using SharedHelpers.DataTransferObjects;

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
        public async Task<IEnumerable<MatchHistoryDto>> GetMatchHistoryAsync(bool trackChanges)
        {
            var list = await (from md in RepositoryContext.Matches
                              join winner in RepositoryContext.Hamsters on md.WinnerId equals winner.Id
                              join loser in RepositoryContext.Hamsters on md.LoserId equals loser.Id
                              select new MatchHistoryDto
                              {
                                  Id = md.Id,
                                  Winner = winner,
                                  Loser = loser,
                              }).ToListAsync();
            return list;
        }

#pragma warning disable CS8603 // Possible null reference return.
            public async Task<Match> GetMatchByIdAsync(int id, bool trackChanges) =>
             await FindByCondition(e => e.Id.Equals(id), trackChanges).SingleOrDefaultAsync();
#pragma warning restore CS8603 // Possible null reference return.
        public void CreateMatch(Match match) => Create(match);
        public void DeleteMatch(Match match) => Delete(match);
    }
}
