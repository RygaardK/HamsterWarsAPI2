using AutoMapper;
using Entities.Models;
using SharedHelpers.DataTransferObjects;

namespace HamsterWarsAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Hamster, HamsterDto>();
            CreateMap<HamsterForUpdateDto, Hamster>();
            CreateMap<HamsterForCreationDto, Hamster>();

            CreateMap<Match, MatchDto>();
            CreateMap<MatchHistoryDto, Match>();
            CreateMap<MatchForCreationDto,  Match>();
        }
    }
}
