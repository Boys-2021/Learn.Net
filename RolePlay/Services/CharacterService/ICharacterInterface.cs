using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RolePlay.Models;

namespace RolePlay.Services.CharacterService
{
    public interface ICharacterInterface
    {
         List<Character> GetAllCharacters();

        Character GetCharacterById(int id);

        List<Character> AddCharacter(Character newCharacter);


    }
}