using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RolePlay.Models;

namespace RolePlay.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CharacterController :ControllerBase
    {   

        public static List<Character> characters = new List<Character>{
            new Character(),
            new Character{
                Name = "Adriana",
                Charac = Role.Queen
            }};

        [HttpGet("GetAd")]
        public ActionResult<List<Character>> Get(){
            return Ok(characters);
        }
        
        public ActionResult<List<Character>> GetSingle(){
            return Ok(characters[0]);
        }
        
    }
}