﻿using Entities.Models;

namespace Contracts
{
    public interface IMatchRepository
    {
        Task<IEnumerable<Match>> GetAllMatchesAsync(bool trackChanges);
        Task<Match> GetMatchByIdAsync(int id, bool trackChanges);
        void CreateMatch(Match match);
        void DeleteMatch(Match match);
    }
}
