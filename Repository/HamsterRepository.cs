using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;


namespace Repository
{
    public class HamsterRepository : RepositoryBase<Hamster>, IHamsterRepository
    {
        public HamsterRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        { }

        public async Task<IEnumerable<Hamster>> GetAllHamstersAsync(bool trackChanges) =>
             await FindAll(trackChanges).OrderBy(c => c.Name).ToListAsync();

#pragma warning disable CS8603 // Possible null reference return.
        public async Task<Hamster> GetHamsterByIdAsync(int id, bool trackChanges) =>
            await FindByCondition(c => c.Id.Equals(id), trackChanges).SingleOrDefaultAsync();
#pragma warning restore CS8603 // Possible null reference return.
        public void CreateHamster(Hamster hamster) => Create(hamster);
        public void DeleteHamster(Hamster hamster) => Delete(hamster);
        public void UpdateHamster(Hamster hamster) => Update(hamster);
    }
}
