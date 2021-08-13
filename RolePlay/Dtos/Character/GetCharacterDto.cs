using RolePlay.Models;

namespace RolePlay.Dtos.Character
{
    public class GetCharacterDto
    {
        public string Name {get;set;} = "Frodo";

        public Role Charac {get;set;} = Role.King;
        
    }
}