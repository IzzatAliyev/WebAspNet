// Copyright (c) IUA. All rights reserved.

namespace Web.Api.Dto.Res;

/// <summary>
/// Book response model.
/// </summary>
/// <param name="name">the name.</param>
/// <param name="company">the company.</param>
/// <param name="region">the region.</param>
/// <param name="city">the city.</param>
/// <param name="post">the post.</param>
/// <returns>the book response model.</returns>
public record BookResponse(string name, string company, string region, string city, string post);
