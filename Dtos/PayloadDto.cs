namespace BenchmarkSourceGenerator.Dtos
{
    public class PayloadDto
    {
        public string PayloadString { get; set; }

        public Guid? PayloadGuid { get; set; }

        public int Number { get; set; }

        public bool PayloadBool { get; set; }

        public DateTime DateTime { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(PayloadString)}={PayloadString}, {nameof(PayloadGuid)}={PayloadGuid.ToString()}, {nameof(Number)}={Number.ToString()}, {nameof(PayloadBool)}={PayloadBool.ToString()}, {nameof(DateTime)}={DateTime.ToString()}}}";
        }
    }
}