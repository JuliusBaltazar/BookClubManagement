﻿

namespace BookClubManagementAPI.Entities
{
    public class User
    {
        public int? id { get; set; }
        public string? username { get; set; }
        
        public string? email { get; set; }
        
        public string? password { get; set; }

        public Profile? profile { get; set; }
    }
}
