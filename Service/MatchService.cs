using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using LoggerService;
using Service.Contracts;
using SharedHelpers.DataTransferObjects;

namespace Service
{
    internal sealed class MatchService : IMatchService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public MatchService(IRepositoryManager repository, ILoggerManager
        logger,IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        private async Task MatchCheckIfItExists(int id, bool trackChanges)
        {
            var match = await _repository.Matches.GetMatchByIdAsync(id, trackChanges);
            if (match is null)
                throw new MatchNotFoundException(id);
        }
        public async Task<IEnumerable<MatchDto>> GetAllMatchesAsync(bool trackChanges)
        {
            var match = await _repository.Matches.GetAllMatchesAsync(trackChanges);
            var matchDto = _mapper.Map<IEnumerable<MatchDto>>(match);
            return matchDto;
        }

        public async Task<MatchDto> GetMatchByIdAsync(int id, bool trackChanges)
        {
            await MatchCheckIfItExists(id, trackChanges);
            var match = await _repository.Matches.GetMatchByIdAsync(id, trackChanges);
            var matchDto = _mapper.Map<MatchDto>(match);
            return matchDto;
        }

        public async Task<MatchDto> CreateMatchAsync(MatchForCreationDto matchForCreationDto, bool trackChanges)
        {
            var match = _mapper.Map<Match>(matchForCreationDto);
            _repository.Matches.CreateMatch(match);
            await _repository.SaveAsync();
            var matchDto = _mapper.Map<MatchDto>(match);
            return matchDto;

        }
        public async Task DeleteMatchAsync(int id, bool trackChanges)
        {
            await MatchCheckIfItExists(id, trackChanges);
            var match = await _repository.Matches.GetMatchByIdAsync(id, trackChanges);
            _repository.Matches.DeleteMatch(match);
            await _repository.SaveAsync();
        }
    } 
}
