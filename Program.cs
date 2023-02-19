using BenchmarkDotNet.Running;

namespace BenchmarkSourceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Benchmarks>();
            //new Benchmarks().NewtonSoftJsonConverter();
            //new Benchmarks().SourceGeneratorConverter();
        }
    }
}