using BenchmarkDotNet.Attributes;

namespace BenchmarkSourceGenerator
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class Benchmarks
    {
        private static string incomingRequest = "{\"requestBool\":true,\"requestGuid\":\"f8b6190c-d7e6-4547-a8ef-bbd29c394d13\",\"requestDate\":null,\"requestType\":\"simple type\",\"requestNumber\":1,\"requestPayload\":{\"payloadString\":\"\",\"payloadGuid\":null,\"number\":2,\"payloadBool\":false,\"dateTime\":\"0001-01-01T00:00:00\"}}";
        private static SourceGeneratorConverter _sourceGeneratorConvertor = new SourceGeneratorConverter();
        private static NewtonSoftJsonConverter _newtonSoftJsonConverter = new NewtonSoftJsonConverter();
        private static JsonSerializerConverter _jsonSerializerConverter = new JsonSerializerConverter();


        [Benchmark]
        public void NewtonSoftJsonConverter()
        {
            var result = _newtonSoftJsonConverter.Process(incomingRequest);
        }

        [Benchmark]
        public void NewtonSoftJsonConverterWthOptions()
        {
            var result = _newtonSoftJsonConverter.ProcessWithOptions(incomingRequest);
        }

        [Benchmark(Baseline = true)]
        public void JsonSerializerConverter()
        {
            var result = _jsonSerializerConverter.ProcessWithOptions(incomingRequest);
        }

        [Benchmark]
        public void SourceGeneratorConverterWithOptions()
        {
            var result = _sourceGeneratorConvertor.ProcessWithOptions(incomingRequest);
        }

        [Benchmark]
        public void SourceGeneratorConverterCreateNewSerializerWithOptions()
        {
            var result = _sourceGeneratorConvertor.ProcessCreateNewSerializerWithOptions(incomingRequest);
        }
    }
}
