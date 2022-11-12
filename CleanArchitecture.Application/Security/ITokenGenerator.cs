using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Security
{
    public interface ITokenGenerator
    {
        public string GenerateToken(string username, string password, int userId);
    }
}
