using BookClubManagementWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace BookClubManagementWeb.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Books()
        {
            var viewModel = new List<BookViewModel>();
            
            viewModel = ResourceData.Books;
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Books(string searchBy, string searchValue)
        {
            var viewModel = new List<BookViewModel>();
            if (string.IsNullOrEmpty(searchValue))
            {
                viewModel = ResourceData.Books;                
                return View(viewModel);
            }
            if (searchBy.ToLower() == "title")
            {
                var searchBooksByTitle = ResourceData.Books.Where(p => p.Title.ToLower().Contains(searchValue.ToLower()));
                return View(searchBooksByTitle);
            }
            if (searchBy.ToLower() == "author")
            {
                var searchBooksByAuthor = ResourceData.Books.Where(p => p.Author.ToLower().Contains(searchValue.ToLower()));
                return View(searchBooksByAuthor);
            }
            if (searchBy.ToLower() == "genre")
            {
                var searchBooksByGenre = ResourceData.Books.Where(p => p.Genre.ToLower().Contains(searchValue.ToLower()));
                return View(searchBooksByGenre);
            }
            viewModel = ResourceData.Books;
            return View(viewModel);
        }
    }
}
