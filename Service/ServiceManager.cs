using AutoMapper;
using Contracts;
using LoggerService;
using Service;
using Service.Contracts;

public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<IHamsterService> _hamsterService;
    private readonly Lazy<IMatchService> _matchesService;
    public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager
    logger, IMapper mapper)
    {
        _hamsterService = new Lazy<IHamsterService>(() => new HamsterService(repositoryManager, logger, mapper));
        _matchesService = new Lazy<IMatchService>(() => new MatchService(repositoryManager, logger, mapper));
    }
    public IHamsterService HamsterService => _hamsterService.Value;
    public IMatchService MatchesService => _matchesService.Value;
}