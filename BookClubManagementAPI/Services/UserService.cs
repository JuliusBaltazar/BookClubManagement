using BookClubManagementAPI.Entities;

namespace BookClubManagementAPI.Services
{
    public class UserService :IUserService
    {
        public async Task<User?>  GetUser(int id)
        {
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
    }
}
