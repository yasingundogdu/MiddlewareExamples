using Microsoft.AspNetCore.Http;
using MiddlewareExamples.Helpers.SessionHelper;
using MiddlewareExamples.Services;
using System;
using System.Threading.Tasks;

namespace MiddlewareExamples.Middlewares
{
    public class TokenRefresherMiddleware
    {
        private readonly RequestDelegate _nextMiddleWare;
        private readonly IFakeApiServices _fakeApiServices;
        private readonly ITokenManager _tokenManager;

        public TokenRefresherMiddleware(RequestDelegate next, IFakeApiServices fakeApiServices, ITokenManager tokenManager)
        {
            _nextMiddleWare = next;
            _fakeApiServices = fakeApiServices;
            _tokenManager = tokenManager;
        }

        public async Task Invoke(HttpContext context)
        {
            if (String.IsNullOrEmpty(_tokenManager.GetToken()))
            {
                string response = _fakeApiServices.Authentication("user", "password");

                if (!String.IsNullOrEmpty(response)) 
                    _tokenManager.SetToken(response);
            }

            await _nextMiddleWare(context);
        }
    }
}