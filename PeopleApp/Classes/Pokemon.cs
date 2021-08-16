namespace PeopleApp.Classes
{
    public class Pokemon
    {
        public string Name {get;set;}

        public string Color{get;set;}

        public void Deconstruct(out string name,out string color){
            name = Name;
            color = Color;
        }
    }
}