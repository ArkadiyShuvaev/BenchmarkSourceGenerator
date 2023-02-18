using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.InProcess.Emit;
using BenchmarkDotNet.Toolchains.InProcess.NoEmit;

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
            var summary = BenchmarkRunner.Run<Benchmarks>();
            //new Benchmarks().NewtonSoftJsonConverter();
            //new Benchmarks().SourceGeneratorConverterCreateNewSerializer();
        }
    }
}