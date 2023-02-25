This benchmark includes deserialization/serialization tests using three approaches:
- Newtonsoft.Json library
- .NET framework using standard System.Text.Json
- .NET platform using source code generator

## How to build and start benchmark
1. Build the project in the Release configuration:
    ```
    dotnet build -c Release
    ```
1. Start the benchmark:
    ```
    dotnet .\bin\Release\net7.0\BenchmarkSourceGenerator.dll
    ```

## Benchmark results

``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19044.2604/21H2/November2021Update)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.101
  [Host] : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2

Job=MediumRun  Toolchain=InProcessEmitToolchain  IterationCount=15
LaunchCount=1  WarmupCount=10

```
|                   Method |     Mean |     Error |    StdDev | Ratio | RatioSD | Rank |   Gen0 |   Gen1 | Allocated | Alloc Ratio |
|------------------------- |---------:|----------:|----------:|------:|--------:|-----:|-------:|-------:|----------:|------------:|
|      GeneratedSerializer | 2.366 μs | 0.0168 μs | 0.0140 μs |  1.00 |    0.00 |    1 | 0.2785 |      - |   1.28 KB |        1.00 |
|     SystemJsonSerializer | 2.637 μs | 0.0166 μs | 0.0147 μs |  1.11 |    0.01 |    2 | 0.3700 |      - |   1.71 KB |        1.34 |
| NewtonSoftJsonSerializer | 6.898 μs | 0.0667 μs | 0.0624 μs |  2.91 |    0.03 |    3 | 1.2817 | 0.0076 |   5.91 KB |        4.62 |
