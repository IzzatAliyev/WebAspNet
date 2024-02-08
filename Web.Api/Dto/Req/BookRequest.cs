// Copyright (c) IUA. All rights reserved.

namespace Web.Api.Dto.Req;

/// <summary>
/// Book request model.
/// </summary>
/// <param name="name">the name.</param>
/// <param name="company">the company.</param>
/// <param name="region">the region.</param>
/// <param name="city">the city.</param>
/// <param name="post">the post.</param>
/// <returns>the book request model.</returns>
public record BookRequest(string name, string company, string region, string city, string post);
