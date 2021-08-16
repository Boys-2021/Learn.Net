namespace My_training.Models
{
    public class Employee
    {
        private static int Count = 0;
        public int Id {get;} = Count++;
        public string Name {get;set;} 

        public Gender Gender {get; set;} = Gender.Male;

    }
}