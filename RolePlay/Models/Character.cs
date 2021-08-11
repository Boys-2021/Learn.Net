namespace RolePlay.Models
{
    public class Character
    {
        public int Id {get;set;}

        public string Name {get;set;} = "Frodo";

        public Role Charac {get;set;} = Role.King;
    }
}