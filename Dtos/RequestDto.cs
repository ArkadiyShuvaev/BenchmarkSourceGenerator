namespace BenchmarkSourceGenerator.Dtos
{
    public class RequestDto
    {
        public bool RequestBool { get; set; }

        public Guid RequestGuid { get; set; }

        public DateTime? RequestDate { get; set; }

        public string RequestType { get; set; }

        public int RequestNumber { get; set; }

        public RequestPayloadDto RequestPayload { get; set; }
    }
}
