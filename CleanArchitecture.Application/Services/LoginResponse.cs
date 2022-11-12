using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Services
{
    public class LoginResponse
    {
        public string Username { get; set; }
        public string Token { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
