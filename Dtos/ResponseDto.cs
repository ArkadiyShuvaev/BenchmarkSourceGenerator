namespace BenchmarkSourceGenerator.Dtos
{
    public class ResponseDto
    {
        public bool ResponseBool { get; set; }

        public Guid ResponseGuid { get; set; }

        public DateTime? ResponseDate { get; set; }

        public string ResponseType { get; set; }

        public int ResponseNumber { get; set; }

        public PayloadDto ResponsePayload { get; set; }
    }
}
