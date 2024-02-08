// Copyright (c) IUA. All rights reserved.

namespace Web.Api.Dto.Req;

/// <summary>
/// Car request model.
/// </summary>
/// <param name="name">the name.</param>
/// <param name="price">the price.</param>
/// <returns>the car request model.</returns>
public record CarRequest(string name, int price);
