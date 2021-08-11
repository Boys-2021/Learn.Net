using System;
using Microsoft.AspNetCore.Mvc;

namespace RolePlay.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TesController:ControllerBase
    {
        static int check = 9;

        public IActionResult Get(){
            return Ok(check);
        }

        [Route("lion")]
        public IActionResult GetLion(){
            return Ok("Adrian");
        }
    }
}