// <copyright file="ClubController.cs" company="Renti Coding Challenge">
//  Renti Coding Challenge
// </copyright>
// ================================================================
// Module   : ClubController
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
    public class ClubController : ControllerBase
    {
        private readonly ILogger<ClubController> _logger;
        private readonly IClubService _clubService;


        public ClubController(ILogger<ClubController> logger, IClubService clubService)
        {
            _logger = logger;
            _clubService = clubService;
        }

        /// <summary>
        /// Get existing Book Club 
        /// </summary>
        [HttpGet]
        [Route("clubs/{id}")]
        public async Task<IActionResult> GetClub(int id)
        {
            var result = await _clubService.GetClub(id);

            if (result is null)
                return NotFound();

            return Ok(result);

        }

        /// <summary>
        /// Create new Book Club 
        /// </summary>
        /// <param name="club"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("clubs")]
        public async Task<IActionResult> CreateClub([FromBody] Club club)
        {
            //TODO
            return Ok();
        }

        /// <summary>
        /// Remove existing Book Club
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("clubs/{id}")]
        public async Task<IActionResult> DeleteClub(int id)
        {
            //TODO
            return Ok();
        }

        /// <summary>
        /// Update existing Book Club
        /// </summary>
        /// <param name="club"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("clubs")]
        public async Task<IActionResult> UpdateClub([FromBody] Club club)
        {
            //TODO
            return Ok();
        }

        /// <summary>
        /// Post a discussion  
        /// </summary>
        /// <param name="id"></param>
        /// <param name="discussionThread"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("clubs/{id}/forums")]
        public async Task<IActionResult> PostForums(int id,[FromBody] DiscussionThread discussionThread)
        {
            //TODO
            return Ok();
        }

        /// <summary>
        /// List all the discussions of the Book Club 
        /// </summary>
        [HttpGet]
        [Route("clubs/{id}/forums")]
        public async Task<IActionResult> GetForums(int id)
        {
            var result = await _clubService.GetForum(id);

            if (result is null)
                return NotFound();

            return Ok(result);

        }



    }
}
