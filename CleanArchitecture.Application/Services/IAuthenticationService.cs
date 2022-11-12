using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public interface IAuthenticationService
    {
        public Task<LoginResponse> Login(string username, string password);
    }
}
