using CleanArchitecture.Application.Security;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly ITokenGenerator _tokenGenerator;

        public AuthenticationService(ITokenGenerator tokenGenerator)
        {
            _tokenGenerator = tokenGenerator;
        }

        public async Task<LoginResponse> Login(string username, string password)
        {
            // retrieve this information from repository by username and pass
            int userId = 123456;

            var response = new LoginResponse()
            {
                ExpirationDate = DateTime.Now,
                // TODO: get token from token generator
                Token = _tokenGenerator.GenerateToken(username, password, userId),
                Username = $"{username} - {password}"
            };

            return response;
        }
    }
}
