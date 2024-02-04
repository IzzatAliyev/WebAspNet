// Copyright (c) IUA. All rights reserved.

namespace Web.Benchmark;

using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

/// <summary>
/// Main class.
/// </summary>
public class Program
{
    /// <summary>
    /// Starting method.
    /// </summary>
    /// <param name="args">the args.</param>
    public static void Main(string[] args)
    {
        var config = DefaultConfig.Instance;
        var summary = BenchmarkRunner.Run<Benchmarks>(config, args);

        // Use this to select benchmarks from the console:
        // var summaries = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, config);
    }
}
