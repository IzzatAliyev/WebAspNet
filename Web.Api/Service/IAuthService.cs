// Copyright (c) IUA. All rights reserved.

namespace Web.Api.Service;

/// <summary>
/// Interface for Auth service.
/// </summary>
public interface IAuthService
{
    /// <summary>
    /// Login user.
    /// </summary>
    /// <param name="username">the username.</param>
    /// <returns>the token.</returns>
    public string Login(string username);
}
