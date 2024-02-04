// Copyright (c) IUA. All rights reserved.

namespace Web.Benchmark;

using BenchmarkDotNet.Attributes;

/// <summary>
/// Benchmark class.
/// </summary>
[MemoryDiagnoser]
public class Benchmarks
{
    /// <summary>
    /// Global setup.
    /// </summary>
    [GlobalSetup]
    public void GlobalSetup()
    {
        // Setup
    }

    /// <summary>
    /// Scenario 1.
    /// </summary>
    [Benchmark]
    public void Scenario1()
    {
        // Implement your benchmark here
    }

    /// <summary>
    /// Scenario 2.
    /// </summary>
    [Benchmark]
    public void Scenario2()
    {
        // Implement your benchmark here
    }
}
