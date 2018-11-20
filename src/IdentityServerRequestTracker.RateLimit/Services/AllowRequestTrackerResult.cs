﻿using System.Threading.Tasks;
using IdentityServerRequestTracker.Models;
using IdentityServerRequestTracker.Services;
using Microsoft.AspNetCore.Http;

namespace IdentityServerRequestTracker.RateLimit.Services
{
    public class AllowRequestTrackerResult : IRequestTrackerResult
    {
        public RequestTrackerEvaluatorDirective Directive => RequestTrackerEvaluatorDirective.AllowRequest;

        public Task ProcessAsync(HttpContext httpContext)
        {
            return Task.CompletedTask;
        }
    }
}