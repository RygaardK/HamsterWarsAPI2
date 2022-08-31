using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IHamsterRepository
    {
        Task<IEnumerable<Hamster>> GetAllHamstersAsync(bool trackChanges);
        Task<Hamster> GetHamsterByIdAsync(int id, bool trackChanges);
        void CreateHamster(Hamster hamster);
        void DeleteHamster(Hamster hamster);
    }
}
