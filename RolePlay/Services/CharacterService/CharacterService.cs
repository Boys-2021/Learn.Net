using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task<List<Character>> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

        public async Task<List<Character>> GetAllCharacters()
        {
            return characters;
        }

        public async Task<Character> GetCharacterById(int id)
        {
            return characters.FirstOrDefault(c => c.Id == id);
        }
    }
}