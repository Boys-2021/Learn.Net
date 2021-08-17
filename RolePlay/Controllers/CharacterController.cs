using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RolePlay.Dtos.Character;
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
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Get(){
            return Ok(await characterService.GetAllCharacters());
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> GetSingle(int id){
            return Ok(await characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> AddCharacter(AddCharacterDto newCharacter){
            return Ok(await characterService.AddCharacter(newCharacter));
        }
        
        [HttpPut]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> UpdateCharacter(UpdateCharacterDto updateCharacter){
            var response = await characterService.UpdateCharacter(updateCharacter);
            if(response.Data == null){
                return NotFound(response);
            }else{
                return Ok(response);
            }
        }
    }
}