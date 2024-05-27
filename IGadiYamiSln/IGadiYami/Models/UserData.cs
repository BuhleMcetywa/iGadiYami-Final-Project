using SQLite;

namespace IGadiYami.Models
{
    public class UserData
    {
        [PrimaryKey, AutoIncrement]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        // public string UserPhoneNumber { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
    }
}
