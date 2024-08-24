// ================================================================
// <copyright file="BookController.cs" company="Renti Coding Challenge">
//  Renti Coding Challenge
// </copyright>
// ================================================================
// Module   : BookController
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

    [Route("v1/Books")]
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;
        private readonly IBookService _bookService;

        public BookController(ILogger<BookController> logger, IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        /// <summary>
        /// Get existing Book
        /// </summary>
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetBook(int id)
        {
            var result = await _bookService.GetBook(id);

            if (result is null)
                return NotFound();

            return Ok(result);

        }

        /// <summary>
        /// Add new Book 
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        [HttpPost]        
        public async Task<IActionResult> AddBook([FromBody] Book book)
        {
            //TODO
            return Ok();
        }

        /// <summary>
        /// Remove Book
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> RemoveBook(int id)
        {
            //TODO
            return Ok();
        }

        /// <summary>
        /// Update existing Book 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPut]       
        public async Task<IActionResult> UpdateBook([FromBody] Book book)
        {
            //TODO
            return Ok();
        }

        /// <summary>
        /// Search Book 
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("search")]
        public async Task<IActionResult> Search([FromBody] SearchBookParameter searchParam)
        {
            var result = await _bookService.SearchBook(searchParam);

            if (result is null)
                return NotFound();

            return Ok(result);
        }
    }
}
