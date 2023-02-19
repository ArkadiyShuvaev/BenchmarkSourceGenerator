using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.InProcess.Emit;

namespace BenchmarkSourceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = DefaultConfig.Instance
                                        .AddJob(Job
                                             .MediumRun
                                             .WithLaunchCount(1)
                                             .WithToolchain(InProcessEmitToolchain.Instance));
            var summary = BenchmarkRunner.Run<Benchmarks>(config);
            //new Benchmarks().NewtonSoftJsonConverter();
            //new Benchmarks().SourceGeneratorConverter();
        }
    }
}