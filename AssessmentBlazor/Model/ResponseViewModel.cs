namespace AssessmentBlazor.Model
{
    public class ResponseViewModel<T>
    {
        public T Data { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
    }

}
