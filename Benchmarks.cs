using BenchmarkDotNet.Attributes;

namespace BenchmarkSourceGenerator
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class Benchmarks
    {
        private readonly string incomingRequest = "{\"requestBool\":true,\"requestGuid\":\"f8b6190c-d7e6-4547-a8ef-bbd29c394d13\",\"requestDate\":null,\"requestType\":\"simple type\",\"requestNumber\":1,\"requestPayload\":{\"payloadString\":\"\",\"payloadGuid\":null,\"number\":2,\"payloadBool\":false,\"dateTime\":\"0001-01-01T00:00:00\"}}";
        private readonly GeneratedSerializer _generatedSerializer = new GeneratedSerializer();
        private readonly NewtonSoftJsonSerializer _newtonSoftJsonSerializer = new NewtonSoftJsonSerializer();
        private readonly SystemJsonSerializer _systemJsonSerializer = new SystemJsonSerializer();


        [Benchmark]
        public void NewtonSoftJsonSerializer()
        {
            var result = _newtonSoftJsonSerializer.Convert(incomingRequest);
        }

        [Benchmark]
        public void SystemJsonSerializer()
        {
            var result = _systemJsonSerializer.Convert(incomingRequest);
        }

        [Benchmark(Baseline = true)]
        public void GeneratedSerializer()
        {
            var result = _generatedSerializer.Convert(incomingRequest);
        }
    }
}
