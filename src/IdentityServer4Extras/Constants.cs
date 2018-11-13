﻿using System.Collections.Generic;

namespace IdentityServer4Extras
{
    public static class Constants
    {
        public static class TokenTypeHints
        {
            public const string RefreshToken = "refresh_token";
            public const string AccessToken = "access_token";
            public const string Subject = "subject";
        }
        public const string ExternalAuthenticationMethod = "external";
        public static List<string> SupportedTokenTypeHints = new List<string>
        {
            TokenTypeHints.RefreshToken,
            TokenTypeHints.AccessToken,
            TokenTypeHints.Subject
        };
        public static class RevocationErrors
        {
            public const string UnsupportedTokenType = "unsupported_token_type";
        }
    }
}