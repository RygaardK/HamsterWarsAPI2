using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using LoggerService;
using Service.Contracts;
using SharedHelpers.DataTransferObjects;

namespace Service
{
    internal sealed class HamsterService : IHamsterService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public HamsterService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        private async Task HamsterCheckIfItExists(int id, bool trackChanges)
        {
            var hamster = await _repository.Hamster.GetHamsterByIdAsync(id, trackChanges);
            if (hamster is null)
                throw new HamsterNotFoundException(id);
        }
        public async Task<IEnumerable<HamsterDto>> GetAllHamstersAsync(bool trackChanges)
        {

            var hamster = await _repository.Hamster.GetAllHamstersAsync(trackChanges);
            var hamsterDto = _mapper.Map<IEnumerable<HamsterDto>>(hamster);
            return hamsterDto;
        }

        public async Task<HamsterDto> GetHamsterByIdAsync(int id, bool trackChanges)
        {
            var hamster = await _repository.Hamster.GetHamsterByIdAsync(id, trackChanges);
            await HamsterCheckIfItExists(id, trackChanges);
            var hamsterDto = _mapper.Map<HamsterDto>(hamster);
            return hamsterDto;
        }
        public async Task<HamsterDto> CreateHamsterAsync(HamsterForCreationDto hamsterForCreationDto)
        {
            var hamster = _mapper.Map<Hamster>(hamsterForCreationDto);
            _repository.Hamster.CreateHamster(hamster);
            await _repository.SaveAsync();
            var hamsterDto = _mapper.Map<HamsterDto>(hamster);
            return hamsterDto;
        }
        public async Task DeleteHamsterAsync(int id, bool trackChanges)
        {
            await HamsterCheckIfItExists(id, trackChanges);
            var hamster = await _repository.Hamster.GetHamsterByIdAsync(id, trackChanges);
            _repository.Hamster.DeleteHamster(hamster);
            await _repository.SaveAsync();
        }

        public async Task UpdateHamsterAsync(int id, HamsterForUpdateDto hamsterForUpdateDto, bool trackChanges)
        {
            await HamsterCheckIfItExists(id, trackChanges);
            var hamster = await _repository.Hamster.GetHamsterByIdAsync(id, trackChanges);
            _mapper.Map(hamsterForUpdateDto, hamster);
            await _repository.SaveAsync();
        }


        public async Task<HamsterDto> GetRandomHamsterAsync(bool trackChanges)
        {
            var allHamsters = await _repository.Hamster.GetAllHamstersAsync(trackChanges);

            Random rand = new Random();
            var hamsterEntity = await _repository.Hamster.GetHamsterByIdAsync(rand.Next(1, allHamsters.Count()), trackChanges);
            while (hamsterEntity is null)
            {
                hamsterEntity = await _repository.Hamster.GetHamsterByIdAsync(rand.Next(1, allHamsters.Count()), trackChanges);
            }

            var hamsterDto = _mapper.Map<HamsterDto>(hamsterEntity);
            return hamsterDto;

        }
    }
}