using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using RolePlay.Dtos.Character;
using RolePlay.Models;

namespace RolePlay.Services.CharacterService
{
    public class CharacterService : ICharacterInterface
    {

        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character{
                Id = 1, 
                Name = "Fernando"
            }
        };

        private readonly IMapper mapper;

        public CharacterService(IMapper map)
        {
            mapper = map;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
            characters.Add(mapper.Map<Character>(newCharacter));
            var response = new ServiceResponse<List<GetCharacterDto>>();
            response.Data = characters.Select(c => mapper.Map<GetCharacterDto>(c)).ToList();
            return response;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
        {
            var response = new ServiceResponse<List<GetCharacterDto>>();
            response.Data = characters.Select(c => mapper.Map<GetCharacterDto>(c)).ToList();
            return response;
        }

        public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
        {
            var response = new ServiceResponse<GetCharacterDto>{Data = mapper.Map<GetCharacterDto>(characters.FirstOrDefault(c => c.Id == id))};
            return response;
        }
    }
}