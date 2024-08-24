// <copyright file="DiscussionThreadController.cs" company="Renti Coding Challenge">
//  Renti Coding Challenge
// </copyright>
// ================================================================
// Module   : DiscussionThreadController
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

    [Route("v1/[controller]")]
    public class DiscussionThreadController : ControllerBase
    {
        private readonly ILogger<DiscussionThreadController> _logger;        

        public DiscussionThreadController(ILogger<DiscussionThreadController> logger)
        {
            _logger = logger;            
        }
    }
}
