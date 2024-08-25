using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BookClubManagementWeb.Models
{
    public class ClubViewModel
    {
        public int Id { get; set; } 
        public string ClubName { get; set; }
        public string Description { get; set; }        
        public List<int> Members { get; set; }
        
        public bool IsMember(int userId)
        {
            if (Members is null)
                return false;

            return Members.Exists(x=>x == userId);

        }
    }
}
