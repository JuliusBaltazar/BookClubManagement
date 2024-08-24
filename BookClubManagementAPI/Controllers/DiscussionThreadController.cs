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
