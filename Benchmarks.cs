using BenchmarkDotNet.Attributes;

namespace BenchmarkSourceGenerator
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    [RPlotExporter]
    public class Benchmarks
    {
        private string _incomingRequest;
        private GeneratedSerializer _generatedSerializer;
        private NewtonSoftJsonSerializer _newtonSoftJsonSerializer;
        private SystemJsonSerializer _systemJsonSerializer;

        [GlobalSetup]
        public void Setup()
        {
            _generatedSerializer = new GeneratedSerializer();
            _newtonSoftJsonSerializer = new NewtonSoftJsonSerializer();
            _systemJsonSerializer = new SystemJsonSerializer();
            _incomingRequest = "{\"requestBool\":true,\"requestGuid\":\"f8b6190c-d7e6-4547-a8ef-bbd29c394d13\",\"requestDate\":null,\"requestType\":\"simple type\",\"requestNumber\":1,\"requestPayload\":{\"payloadString\":\"\",\"payloadGuid\":null,\"number\":2,\"payloadBool\":false,\"dateTime\":\"0001-01-01T00:00:00\"}}";
        }

        [Benchmark]
        public void NewtonSoftJsonSerializer()
        {
            var result = _newtonSoftJsonSerializer.Convert(_incomingRequest);
        }

        [Benchmark]
        public void SystemJsonSerializer()
        {
            var result = _systemJsonSerializer.Convert(_incomingRequest);
        }

        [Benchmark(Baseline = true)]
        public void GeneratedSerializer()
        {
            var result = _generatedSerializer.Convert(_incomingRequest);
        }
    }
}
