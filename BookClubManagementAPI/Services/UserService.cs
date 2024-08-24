// <copyright file="UserService.cs" company="Renti Coding Challenge">
//  Renti Coding Challenge
// </copyright>
// ================================================================
// Module   : UserService
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
    public class UserService :IUserService
    {
        public async Task<User?>  GetUser(int id)
        {
            //TODO : Database is not yet implemented. Uses hardcoded values temporary.

            var dummyList =new Dictionary<int,User>();
            dummyList.Add(1, new User()
            {
                id = 1,
                username = "booklover1",
                email = "booklover1@example.com",
                password = "hashedpassword1",
                profile = new Profile()
                {
                    name = "Alice Johnson",
                    reading_preferences = new[] { "Fiction", "Mystery", "Science Fiction" }
                }
            });
            dummyList.Add(2, new User()
            {
                id =2,
                username = "literaturefan",
                email = "literaturefan@example.com",
                password = "hashedpassword2",
                profile = new Profile()
                {
                    name = "Bob Smith",
                    reading_preferences = new[] { "Non-Fiction", "Biography", "History" }
                }
            });
            dummyList.Add(3, new User()
            {
                id =3,
                username = "novelenthusiast",
                email = "novelenthusiast@example.com",
                password = "hashedpassword3",
                profile = new Profile()
                {
                    name = "Charlie Brown",
                    reading_preferences = new[] { "Fantasy", "Adventure", "Young Adult" }
                }
            });

            if (dummyList.ContainsKey(id))
                return dummyList[id];
            else
                return null;            
        }

        public async Task<UserBookList?> GetUserBooks(int id)
        {
            //TODO : Database is not yet implemented. Uses hardcoded values temporary.

            var dummyList = new Dictionary<int, UserBookList>();
            dummyList.Add(1, new UserBookList()
            {
                user_id = 1,
                books = new List<UserBook>()
              {
                new UserBook(){book_id =1,status = "read"},
                new UserBook(){book_id=3, status = "currently reading"}
               }
            });
            dummyList.Add(2, new UserBookList()
            {
                user_id = 2,
                books = new List<UserBook>()
              {
                new UserBook(){book_id =4,status = "want to read"},                
               }
            });
            dummyList.Add(3, new UserBookList()
            {
                user_id = 3,
                books = new List<UserBook>()
              {
                new UserBook(){book_id =1,status = "currently reading"},
                new UserBook(){book_id=3, status = "want to read"}
               }
            });

            if (dummyList.ContainsKey(id))
                return dummyList[id];
            else
                return null;

        }
    }
}
