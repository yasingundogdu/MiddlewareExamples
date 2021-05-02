using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareExamples.Helpers.SessionHelper
{
    public class SessionManager
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public SessionManager(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string Token
        {
            get
            {
                return _httpContextAccessor.HttpContext.Session.GetString("Token") != null ? _httpContextAccessor.HttpContext.Session.GetString("Token") : "";
            }

            set
            {
                _httpContextAccessor.HttpContext.Session.SetString("Token", value);
            }
        }
    }
}
