using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareExamples.Helpers.SessionHelper
{
    public class TokenManager : ITokenManager
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private string Token;
        public TokenManager(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetToken() => _httpContextAccessor.HttpContext.Session.GetString("Token");
        
        public void SetToken(string token) => _httpContextAccessor.HttpContext.Session.SetString("Token", token);

    }
}
