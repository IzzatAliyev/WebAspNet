// Copyright (c) IUA. All rights reserved.

namespace Web.Api.Dto.Res;

/// <summary>
/// Car response model.
/// </summary>
/// <param name="name">the name.</param>
/// <param name="price">the price.</param>
/// <returns>the car response model.</returns>
public record CarResponse(string name, int price);
