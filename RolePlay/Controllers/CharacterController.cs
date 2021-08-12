using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RolePlay.Models;
using RolePlay.Services.CharacterService;

namespace RolePlay.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CharacterController :ControllerBase
    {   

        private static ICharacterInterface characterService;
        public CharacterController(ICharacterInterface characterServic)
        {
            characterService = characterServic;
        }

        [HttpGet]
        public ActionResult<List<Character>> Get(){
            return Ok(characterService.GetAllCharacters());
        }
        
        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id){
            return Ok(characterService.GetCharacterById(id));
        }

        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter){
            return Ok(characterService.AddCharacter(newCharacter));
        }
        
    }
}