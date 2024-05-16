namespace Code_Assessment.Dto
{
    public class BaseResponce<T>
    {
        public string Message { get; set; }
        public bool Status { get; set; }
        public T Data { get; set; }
    }
}
