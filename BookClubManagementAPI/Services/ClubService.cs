// <copyright file="ClubService.cs" company="Renti Coding Challenge">
//  Renti Coding Challenge
// </copyright>
// ================================================================
// Module   : ClubService
// Author   : Julius Baltazar Jr
// Date     : 08/24/2024
// ================================================================
// Revision History
// dd/mm/yyyy | Author | Change description
// ================================================================
// ================================================================

using BookClubManagementAPI.Entities;

namespace BookClubManagementAPI.Services
{
    public class ClubService : IClubService
    {
        public async Task<Club?> GetClub(int id)
        {
            //TODO : Database is not yet implemented. Uses hardcoded values temporary.

            var dummyList = new Dictionary<int, Club>();
            dummyList.Add(1, new Club()
            {
                id = 1,
                name = "Fiction Fans",
                description = "A club for fiction lovers",                
                members = new[] {1,3}                
            });

            dummyList.Add(2, new Club()
            {
                id = 2,
                name = "History Buffs",
                description = "A club for those who love history.",
                members = new[] {2}
            });

            dummyList.Add(3, new Club()
            {
                id = 3,
                name = "Sci-Fi Enthusiasts",
                description = "A club for science fiction fans.",
                members = new[] { 1,3 }
            });



            if (dummyList.ContainsKey(id))
                return dummyList[id];
            else
                return null;
        }

        public async Task<IEnumerable<DiscussionThread>?> GetForum(int id)
        {
            //TODO : Database is not yet implemented. Uses hardcoded values temporary.

            var dummyList = new Dictionary<int, DiscussionThread>();
            dummyList.Add(1, new DiscussionThread()
            {
                id = 1,
                book_club_id = 2,
                title = "Discussion on 'The Great Gatsby",
                author_id = 1,
                Posts = new List<Post>()
                {
                    new Post()
                    {
                        user_id= 1,
                        content= "I love the themes in this book. What do you think about the portrayal of the American Dream?",
                    },
                    new Post()
                    {
                        user_id = 3,
                        content ="I found the characters fascinating. Gatsby's mysterious background kept me intrigued.",
                    }
                }

            });
            dummyList.Add(2, new DiscussionThread()
            {
                id = 2,
                book_club_id = 3,
                title = "Thoughts on 'Dune'",
                author_id = 3,
                Posts = new List<Post>()
                {
                    new Post()
                    {
                        user_id= 3,
                        content= "The world-building in this book is incredible. Has anyone watched the movie adaptation?",
                    },
                    new Post()
                    {
                        user_id = 1,
                        content ="Yes, I have! The movie did justice to the book in many ways, but the book is definitely richer in detail.",
                    }
                }

            });

            return dummyList.Where(x => x.Value.book_club_id == id)
                   .Select(x => x.Value);
        }
    }
}
