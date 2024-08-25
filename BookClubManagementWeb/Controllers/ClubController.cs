using BookClubManagementWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BookClubManagementWeb.Controllers
{
    public class ClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BookClubs()
        {
            var viewModel = new List<ClubViewModel>();
            viewModel = ResourceData.Clubs;
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult BookClubs(ClubViewModel model)
        {
            if (model!=null)
            {
                var lastCount = ResourceData.Clubs.Count;

                ResourceData.Clubs.Add(
                    new ClubViewModel()
                    {
                        Id = lastCount++,
                        ClubName = model.ClubName,
                        Description = model.Description,
                        Members = new List<int>()
                    }); ;
            }

            var viewModel = new List<ClubViewModel>();
            viewModel = ResourceData.Clubs;
            return View(viewModel);
        }

        public IActionResult Create()
        {            
            return View();
        }

        private int GetUserId()
        {
            int result = 0;
            var claimsPrincipal = HttpContext.User;
            if (claimsPrincipal != null)
            {
                var identity = claimsPrincipal.Identity as ClaimsIdentity;
                ViewBag.Id = identity.FindFirst(ClaimTypes.Role)?.Value;
                int.TryParse(ViewBag.Id, out result);
            }
            return result;
        }
    }
}
