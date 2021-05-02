using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareExamples.Helpers.SessionHelper
{
    public interface ITokenManager
    {
        string GetToken();
        void SetToken(string token);
    }
}
