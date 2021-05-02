using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareExamples.Services
{
    public class FakeApiServices
    {
        public string Authentication(string user, string password)
        {
            if (user == "user" && password == "password")
                return Guid.NewGuid().ToString();
            return null;
            
        }
    }
}
