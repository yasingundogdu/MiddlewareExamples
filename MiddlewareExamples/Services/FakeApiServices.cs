using System;

namespace MiddlewareExamples.Services
{
    public class FakeApiServices : IFakeApiServices
    {
        public string Authentication(string user, string password)
        {
            if (user.Equals("user") && password.Equals("password"))
                return Guid.NewGuid().ToString();
            
            return String.Empty;
        }
    }
}
