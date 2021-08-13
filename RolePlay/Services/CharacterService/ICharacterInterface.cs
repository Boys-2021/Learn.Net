using System.Collections.Generic;
using System.Threading.Tasks;
using RolePlay.Dtos.Character;
using RolePlay.Models;

namespace RolePlay.Services.CharacterService
{
    public interface ICharacterInterface
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();

        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);

        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);


    }
}