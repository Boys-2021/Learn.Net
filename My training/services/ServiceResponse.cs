namespace My_training.services
{
    public class ServiceResponse<T>
    {
        public T Data {get;set;} 
        public string Message {get;set;} = "Success";

        public bool Success {get;set;} = true;
    }
}