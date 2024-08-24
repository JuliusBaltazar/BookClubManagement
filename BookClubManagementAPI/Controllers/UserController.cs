// <copyright file="UserController.cs" company="Renti Coding Challenge">
//  Renti Coding Challenge
// </copyright>
// ================================================================
// Module   : UserController
// Author   : Julius Baltazar Jr
// Date     : 08/24/2024
// ================================================================
// Revision History
// dd/mm/yyyy | Author | Change description
// ================================================================
// ================================================================

using Microsoft.AspNetCore.Mvc;
using BookClubManagementAPI.Entities;
using BookClubManagementAPI.Services;

namespace BookClubManagementAPI.Controllers
{
    [ApiController]

    [Route("v1/BookClub")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger,IUserService userService)
        {            
            _logger = logger;
            _userService = userService;
        }


        /// <summary>
        /// Get existing Book Club user
        /// </summary>
        [HttpGet]
        [Route("users/{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var result = await _userService.GetUser(id);

            if (result is null)
                return NotFound();

            return Ok(result);
           
        }

        /// <summary>
        /// Create new Book Club user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("users")]
        public async Task<IActionResult> CreateUser([FromBody] User user)
        {
            return Ok();
        }

        /// <summary>
        /// Remove existing Book Club user
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("users/{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            return Ok();
        }

        /// <summary>
        /// Update existing Book Club user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("users")]
        public async Task<IActionResult> UpdateUser([FromBody] User user)
        {
            return Ok();
        }

        /// <summary>
        /// Join user to existing Book Club
        /// </summary>
        /// <param name="id"></param>
        /// <param name="clubId"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("users/{id}/clubs/{clubId}")]
        public async Task<IActionResult> JoinClub(int id, int clubId)
        {
            return Ok();
        }

        /// <summary>
        /// Remove user from existing Book Club
        /// </summary>
        /// <param name="id"></param>
        /// <param name="clubId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("users/{id}/clubs/{clubId}")]
        public async Task<IActionResult> LeaveClub(int id, int clubId)
        {
            //TODO
            return Ok();
        }

        /// <summary>
        /// Get user list of reading books.
        /// </summary>     
        /// <param name="id"></param>
        [HttpGet]
        [Route("users/{id}/books")]
        public async Task<IActionResult> GetReadingBooks(int id)
        {
            var result = await _userService.GetUserBooks(id);

            if (result is null)
                return NotFound();

            return Ok(result);
          

        }

        /// <summary>
        /// Add a book on user list of reading books.
        /// </summary>  
        /// <param name="id"></param>
        /// <param name="userBook"></param>
        [HttpPost]
        [Route("users/{id}/books")]
        public async Task<IActionResult> AddReadingBooks(int id, [FromBody] UserBook userBook)
        {
            //TODO
            return Ok();

        }

    }
}
