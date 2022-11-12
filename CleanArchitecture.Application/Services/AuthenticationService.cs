using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public async Task<LoginResponse> Login(string username, string password)
        {
            var response = new LoginResponse()
            {
                ExpirationDate = DateTime.Now,
                // TODO: get token from token generator
                Token = $"Token from service {password}",
                Username = $"{username} - {password}"
            };

            return response;
        }
    }
}
