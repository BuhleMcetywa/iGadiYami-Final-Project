using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGadiYami.Models.User_Profile
{
    public class UserProfile
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserSurname { get; set; }
        public string UserPhone { get; set; }
        public string UserBio { get; set; }
        public string UserImage { get; set; }
    }
}
