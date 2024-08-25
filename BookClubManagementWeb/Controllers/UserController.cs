using BookClubManagementWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using System.Collections.Generic;
using System.Security.Claims;

namespace BookClubManagementWeb.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UserProfile()
        {
            var viewModel = new UserViewModel
            {
               FullName = HttpContext.User.Identity.Name,                               
            };
            var id = this.GetUserId();
            viewModel.ReadingPreference = this.GetReadingPreference(id);
            viewModel.Books = this.GetUserBooks(id);
            viewModel.Clubs = this.GetClubs(id);

            return View(viewModel);            
        }

        private List<ClubViewModel> GetClubs(int id)
        {
            var result = new List<ClubViewModel>();
            switch (id)
            {
                case 1:
                    result.Add(new ClubViewModel() { ClubName = "Fiction Fans", Description = "A club for fiction lovers." });
                    result.Add(new ClubViewModel() { ClubName = "Sci-Fi Enthusiasts", Description = "A club for science fiction fans." });
                    break;
                case 2:
                    result.Add(new ClubViewModel() { ClubName = "History Buffs", Description = "A club for those who love history." });
                    break;
                case 3:
                    result.Add(new ClubViewModel() { ClubName = "Fiction Fans", Description = "A club for fiction lovers." });
                    result.Add(new ClubViewModel() { ClubName = "Sci-Fi Enthusiasts", Description = "A club for science fiction fans." });
                    break;
            }
            return result;
        }

        private string GetReadingPreference(int id)
        {
            var result = "None";
            switch (id)
            {
                case 1:
                    result = "Fiction, Mystery, Science Fiction";
                    break;
                case 2:
                    result = "Non-Fiction, Biography, History";
                    break;
                case 3:
                    result = "Fantasy, Adventure, Young Adult";
                    break;
            }
            return result;
        }
        private List<UserBookViewModel> GetUserBooks(int id)
        {
            var result = new List<UserBookViewModel>();
            switch (id)
            {
                case 1:
                    result.Add(new UserBookViewModel()
                    {
                        Title = "The Great Gatsby",
                        Author = "F. Scott Fitzgerald",
                        Genre = "Fiction",
                        Status = "read"
                    });
                    result.Add(new UserBookViewModel()
                    {
                        Title = "Dune",
                        Author = "Frank Herbert",
                        Genre = "Science Fiction",
                        Status = "currently reading"
                    });
                    break;
                case 2:
                    result.Add(new UserBookViewModel()
                    {
                        Title = "Star Wars",
                        Author = "John Doe",
                        Genre = "Science Fiction",
                        Status = "want to read"
                    });
                    break;
                case 3:
                    result.Add(new UserBookViewModel()
                    {
                        Title = "The Great Gatsby",
                        Author = "F. Scott Fitzgerald",
                        Genre = "Fiction",
                        Status = "currently reading"
                    });
                    result.Add(new UserBookViewModel()
                    {
                        Title = "Dune",
                        Author = "Frank Herbert",
                        Genre = "Science Fiction",
                        Status = "want to read"
                    });
                    break;
            }
            return result;
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
