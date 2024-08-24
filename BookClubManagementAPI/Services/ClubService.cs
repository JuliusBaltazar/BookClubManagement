using BookClubManagementAPI.Entities;

namespace BookClubManagementAPI.Services
{
    public class ClubService : IClubService
    {
        public async Task<Club?> GetClub(int id)
        {
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
    }
}
