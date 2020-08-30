using AutoMapper;
using Bayolu.AppService.Dto;
using Bayolu.Domain;
using Bayolu.ViewModel;

namespace Bayolu.Api.Configurations
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<UserDto, UserViewModel>().ReverseMap();
        }
    }
}
