﻿// <copyright file="BookService.cs" company="Renti Coding Challenge">
//  Renti Coding Challenge
// </copyright>
// ================================================================
// Module   : BookService
// Author   : Julius Baltazar Jr
// Date     : 08/24/2024
// ================================================================
// Revision History
// dd/mm/yyyy | Author | Change description
// ================================================================
// ================================================================

using BookClubManagementAPI.Entities;
using System.Collections.Generic;

namespace BookClubManagementAPI.Services
{
    public class BookService :IBookService
    {
        private Dictionary<int, Book> DummyList=new Dictionary<int, Book>();
        public async Task<Book?> GetBook(int id)
        {
            //TODO : Database is not yet implemented. Uses hardcoded values temporary.

            InitBooks();   

            if (DummyList.ContainsKey(id))
                return DummyList[id];
            else
                return null;
        }

        public async Task<IEnumerable<Book>?> SearchBook(SearchBookParameter searchParam)
        {
            //TODO : Database is not yet implemented. Uses hardcoded values temporary.

            IEnumerable<Book> result=null;

            InitBooks();
            
            if (searchParam == null)
                return null;

            if (!string.IsNullOrEmpty(searchParam.title))
            {
                return DummyList.Where(x => x.Value.title.ToLower().Contains(searchParam.title.ToLower()))
                    .Select(x => x.Value);                    
                    
            }
            if (!string.IsNullOrEmpty(searchParam.author))
            {
                return DummyList.Where(x => x.Value.author.ToLower().Contains(searchParam.author.ToLower()))
                    .Select(x => x.Value);

            }
            if (!string.IsNullOrEmpty(searchParam.genre))
            {
                return DummyList.Where(x => x.Value.genre.ToLower().Contains(searchParam.genre.ToLower()))
                    .Select(x => x.Value);

            }
            
            return DummyList.Select(x => x.Value);
        }

        private void InitBooks()
        {
            //TODO : Database is not yet implemented. Uses hardcoded values temporary.
            DummyList = new Dictionary<int, Book>();
            DummyList.Add(1, new Book()
            {
                id = 1,
                title = "The Great Gatsby",
                author = "F. Scott Fitzgerald",
                genre = "Fiction",
                cover_image = "link_to_cover_image"
            });
            DummyList.Add(2, new Book()
            {
                id = 2,
                title = "Becoming",
                author = "Michelle Obama",
                genre = "Biography",
                cover_image = "link_to_cover_image"
            });
            DummyList.Add(3, new Book()
            {
                id = 3,
                title = "Dune",
                author = "Frank Herbert",
                genre = "Science Fiction",
                cover_image = "link_to_cover_image"
            });
        }
    }
}
