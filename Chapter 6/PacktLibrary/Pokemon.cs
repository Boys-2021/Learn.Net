namespace Packt.Shared
{
    public class Pokemon
    {
        public int Health {get;set;} =100;
        public int attack {get;set;}

        public static Pokemon Fight(Pokemon pokeOne,Pokemon pokeTwo){
            pokeOne.Health -= pokeTwo.attack;
            return pokeOne;
        }

        public static Pokemon operator -(Pokemon pokeOne,Pokemon pokeTwo){
            return Fight(pokeOne,pokeTwo);
        }

        public int GetNameLength(string Name){
            return Name.Length;
        }
    }
}