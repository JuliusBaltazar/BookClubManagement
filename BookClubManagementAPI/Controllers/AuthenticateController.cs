using BookClubManagementAPI.Dtos;
using BookClubManagementAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookClubManagementAPI.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class AuthenticateController : ControllerBase
    {

        [AllowAnonymous]
        [HttpPost("login")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            //TODO
            //var response = await _authenticationService.Login(request);
            //return Ok(response);
            return Ok(null);
        }

        [AllowAnonymous]
        [HttpPost("register")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            //TODO
            //var response = await _authenticationService.Register(request);

            return Ok(null);
        }
    }
}
