using System.Collections.Generic;
using System.Threading.Tasks;
using RolePlay.Models;

namespace RolePlay.Services.CharacterService
{
    public interface ICharacterInterface
    {
        Task<List<Character>> GetAllCharacters();

        Task<Character> GetCharacterById(int id);

        Task<List<Character>> AddCharacter(Character newCharacter);


    }
}