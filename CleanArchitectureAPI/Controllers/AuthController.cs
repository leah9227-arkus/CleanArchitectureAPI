using CleanArchitecture.Application.Services;
using CleanArchitecture.Contracts.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitectureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(new { ImAlive = true });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            var loginResponse = await _authenticationService.Login(loginRequest.Username, loginRequest.Password);
            
            var response = new CleanArchitecture.Contracts.Auth.LoginResponse()
            {
                Username = loginResponse.Username,
                ExpirationDate = loginResponse.ExpirationDate,
                Token = loginResponse.Token
            };

            return Ok(response);
        }
    }
}
