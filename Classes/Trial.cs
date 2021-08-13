namespace Classes
{
    public class Trial
    {
        private static int Count = 1;
        private string id;
        public string Id {
            get{
                return id;
            }
            set{
                id = value + Count++;
            }
        }
    }
}