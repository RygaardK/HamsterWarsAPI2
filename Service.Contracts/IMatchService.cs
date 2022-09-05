using SharedHelpers.DataTransferObjects;


namespace Service.Contracts
{
    public interface IMatchService
    {
        Task<IEnumerable<MatchDto>> GetAllMatchesAsync(bool trackChanges);
        Task<IEnumerable<MatchHistoryDto>> GetMatchHistoryAsync(bool trackChanges);
        Task<MatchDto> GetMatchByIdAsync(int id, bool trackChanges);
        Task<MatchDto> CreateMatchAsync(MatchForCreationDto matchForCreationDto, bool trackChanges);
        Task DeleteMatchAsync(int id, bool trackChanges);
    
    }
}
