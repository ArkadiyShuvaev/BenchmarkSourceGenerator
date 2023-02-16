namespace BenchmarkSourceGenerator.Dtos
{
    public class RequestPayloadDto
    {
        public string Name { get; set; }

        public Guid Id { get; set; }

        public int Age { get; set; }

        public bool IsWealthy { get; set; }

        public DateTime Birthday { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Id)}={Id.ToString()}, {nameof(Age)}={Age.ToString()}, {nameof(IsWealthy)}={IsWealthy.ToString()}, {nameof(Birthday)}={Birthday.ToString()}}}";
        }
    }
}