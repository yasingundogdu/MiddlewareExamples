using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareExamples.Services
{
    public interface IFakeApiServices
    {
        string Authentication(string user, string password);
    }
}
