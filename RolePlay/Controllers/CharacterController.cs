using System.Collections.Generic;
using System.Threading.Tasks;
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
        public async Task<ActionResult<List<Character>>> Get(){
            return Ok(await characterService.GetAllCharacters());
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetSingle(int id){
            return Ok(await characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<ActionResult<List<Character>>> AddCharacter(Character newCharacter){
            return Ok(await characterService.AddCharacter(newCharacter));
        }
        
    }
}