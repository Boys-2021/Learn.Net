using AutoMapper;
using RolePlay.Dtos.Character;
using RolePlay.Models;

namespace RolePlay
{

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character,GetCharacterDto>();
            CreateMap<AddCharacterDto,Character>();
            CreateMap<UpdateCharacterDto,Character>();
        }
    }
}