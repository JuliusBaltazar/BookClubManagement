namespace BookClubManagementWeb.Models
{
    public static class ResourceData
    {
       public static List<ClubViewModel> Clubs = new List<ClubViewModel>();
       public static void InitData()
        {
            InitClub();
        }
        private static void InitClub()
        {
            Clubs.Clear();
            Clubs.Add(
                new ClubViewModel() 
                { 
                    ClubName = "Fiction Fans", 
                    Description = "A club for fiction lovers." ,
                    Members = new List<int> { 1, 3 }                    
                });
            Clubs.Add(
                new ClubViewModel()
                {
                    ClubName = "History Buffs",
                    Description = "A club for those who love history.",
                    Members = new List<int> { 2 }
                });
            Clubs.Add(
                new ClubViewModel()
                {
                    ClubName = "Sci-Fi Enthusiasts",
                    Description = "A club for science fiction fans.",
                    Members = new List<int> { 1, 3 }
                });
        }
    }
}
