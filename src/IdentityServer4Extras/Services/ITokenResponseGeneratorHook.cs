﻿using System.Threading.Tasks;
using IdentityServer4.ResponseHandling;
using IdentityServer4.Validation;

namespace IdentityServer4Extras.Services
{
    public interface ITokenResponseGeneratorHookHost
    {
        Task<(string accessToken, string refreshToken)> CreateAccessTokenAsync(ValidatedTokenRequest request);
    }
    public interface ITokenResponseGeneratorHook
    {
        Task<TokenResponse> ProcessAsync(ITokenResponseGeneratorHookHost host,TokenRequestValidationResult validationResult);
    }
}