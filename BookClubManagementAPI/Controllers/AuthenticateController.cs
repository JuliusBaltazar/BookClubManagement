// ================================================================
// <copyright file="AuthenticateController.cs" company="Renti Coding Challenge">
//  Renti Coding Challenge
// </copyright>
// ================================================================
// Module   : AuthenticateController
// Author   : Julius Baltazar Jr
// Date     : 08/24/2024
// ================================================================
// Revision History
// dd/mm/yyyy | Author | Change description
// ================================================================
// ================================================================

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

        /// <summary>
        /// User Login
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
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

        /// <summary>
        /// User sign up
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
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
