namespace BookClubManagementWeb.Models
{
    public static class ResourceData
    {
       public static List<ClubViewModel> Clubs = new List<ClubViewModel>();
       public static List<BookViewModel> Books = new List<BookViewModel>();
        public static List<UserBookViewModel> UserBooks = new List<UserBookViewModel>();
        public static void InitData()
        {
            InitClub();
            InitBook();
        }
        private static void InitClub()
        {
            Clubs.Clear();
            Clubs.Add(
                new ClubViewModel() 
                { 
                    Id = 1,
                    ClubName = "Fiction Fans", 
                    Description = "A club for fiction lovers." ,
                    Members = new List<int> { 1, 3 }                    
                });
            Clubs.Add(
                new ClubViewModel()
                {
                    Id=2,
                    ClubName = "History Buffs",
                    Description = "A club for those who love history.",
                    Members = new List<int> { 2 }
                });
            Clubs.Add(
                new ClubViewModel()
                {

                    Id=3,
                    ClubName = "Sci-Fi Enthusiasts",
                    Description = "A club for science fiction fans.",
                    Members = new List<int> { 1, 3 }
                });
        }
        private static void InitBook()
        {
            Books.Clear();
            Books.Add(
                new BookViewModel()
                {
                    Id = 1, 
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    Genre = "Fiction"
                }
                );
            Books.Add(
                new BookViewModel()
                {
                    Id = 2, 
                    Title = "Becoming",
                    Author = "Michelle Obama",
                    Genre = "Biography"
                }
                );
            Books.Add(
                new BookViewModel()
                {
                    Id = 3,
                    Title = "Dune",
                    Author = "Frank Herbert",
                    Genre = "Science Fiction"
                }
                );
        }

        private static void InitUserBook()
        {
            UserBooks.Clear();            
        }
    }
}
