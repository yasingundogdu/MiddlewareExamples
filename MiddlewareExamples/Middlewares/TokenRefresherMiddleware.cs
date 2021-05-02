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
        private readonly FakeApiServices _fakeApiServices;
        private readonly SessionManager _sessionManager;

        public TokenRefresherMiddleware(RequestDelegate next, FakeApiServices fakeApiServices, SessionManager sessionManager)
        {
            _nextMiddleWare = next;
            _fakeApiServices = fakeApiServices;
            _sessionManager = sessionManager;
        }

        public async Task Invoke(HttpContext context)
        {
            if (_sessionManager.Token == null || _sessionManager.Token == "")
            {
                string response = _fakeApiServices.Authentication("user", "password");

                if (response != null)
                {
                    _sessionManager.Token = response;
                }
            }

            await _nextMiddleWare(context);
        }
    }
}