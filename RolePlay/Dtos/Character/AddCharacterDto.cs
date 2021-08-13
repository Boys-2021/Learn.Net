using RolePlay.Models;

namespace RolePlay.Dtos.Character
{
    public class AddCharacterDto
    {
        public int Id {get;set;}

        public string Name {get;set;} = "Frodo";

        public Role Charac {get;set;} = Role.King;
    }
}