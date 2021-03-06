﻿using IdentityServer4RequestTracker;
using Microsoft.Extensions.DependencyInjection;

namespace IdentityServerRequestTrackerEvaluator.ClientRateLimiter
{
    public static class ClientRateLimiterExtensions
    {
        public static IServiceCollection AddClientRateLimiter(this IServiceCollection services)
        {
            services.AddTransient<ClientRateLimiterRequestTrackerResult>();
            services.AddSingleton<IIdentityServerRequestTrackerEvaluator, ClientRateLimiter>();
            return services;
        }
    }
}