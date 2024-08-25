using Microsoft.AspNetCore.Mvc;
using BookClubManagementWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using System.Collections.Generic;
using System.Security.Claims;

namespace BookClubManagementWeb.Controllers
{
    public class ForumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
