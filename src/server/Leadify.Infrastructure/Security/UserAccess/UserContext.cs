﻿using Leadify.Application.Abstraction.UserAccess;
using Leadify.Infrastructure.Extensions;
using Microsoft.AspNetCore.Http;

namespace Leadify.Infrastructure.Security.UserAccess;

public class UserContext : IUserContext
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public UserContext(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public Guid UserId =>
        _httpContextAccessor.HttpContext?.User.GetUserId()
        ?? throw new ApplicationException("User context is unavailable");

    public string IdentityId =>
        _httpContextAccessor.HttpContext?.User.GetIdentityId()
        ?? throw new ApplicationException("User context is unavailable");
}