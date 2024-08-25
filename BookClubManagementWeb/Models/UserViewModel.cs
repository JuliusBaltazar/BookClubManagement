using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookClubManagementWeb.Models
{
    public class UserViewModel
    {
        public string FullName { get; set; }
        public string ReadingPreference { get; set; }
        public List<UserBookViewModel> Books { get; set; }
        public List<ClubViewModel>Clubs { get; set; }
    }
}
