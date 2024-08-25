using System.ComponentModel.DataAnnotations;

namespace BookClubManagementWeb.Models
{
    public class UserBookViewModel
    {
        public int userId { get; set; }
        public string Title { get; set; }     
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Status { get; set; }
    }
}
