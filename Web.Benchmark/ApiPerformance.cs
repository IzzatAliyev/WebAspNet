// Copyright (c) IUA. All rights reserved.

namespace Web.Benchmark;

using System;
using System.Net.Http;
using BenchmarkDotNet.Attributes;

/// <summary>
/// Benchmark class.
/// </summary>
[MemoryDiagnoser]
public class ApiPerformance
{
    private HttpClient httpClient;

    /// <summary>
    /// Global setup.
    /// </summary>
    [GlobalSetup]
    public void GlobalSetup()
    {
        this.httpClient = new HttpClient();
        this.httpClient.BaseAddress = new Uri("http://localhost:5116");
    }

    /// <summary>
    /// Get health.
    /// </summary>
    [Benchmark]
    public void GetHealth()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, "/api/health");
        var response = this.httpClient.Send(request);
        System.Console.WriteLine(response.Content.ReadAsStringAsync());
    }
}
