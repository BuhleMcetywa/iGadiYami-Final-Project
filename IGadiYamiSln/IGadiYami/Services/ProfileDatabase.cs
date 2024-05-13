using IGadiYami.Models.User_Profile;
using IGadiYami.Views;
using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Protection.PlayReady;

namespace IGadiYami.Services
{
    public class ProfileDatabase : IProfileDatabase
    {
        private SQLiteConnection _dbConnection;

        public ProfileDatabase()
        {
            _dbConnection = new SQLiteConnection(GetDatabasePath());
            _dbConnection.CreateTable<UserProfile>();
        }
        public string GetDatabasePath()
        {
            string fileName = "profiledatabase.db";
            string pathToDb = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return pathToDb + fileName;
        }
        public void SeedDatabase()
        { 
            if (_dbConnection.Table<UserProfile>().Count() == 0)
            {
                UserProfile profile = new UserProfile()
                {
                    UserName = "Test",
                    UserSurname = "Test2",
                    UserEmail = "Test@gmail.com",
                    UserBio = "Testing",
                    UserPhone = "12345678910",
                    UserImage = "no image"
                };
                _dbConnection.Insert(profile);
            }
        }

        // Methods
        public void CreatUser(string userName, string userSurname, string userEmail, string userBio, string userPhone, string userImage)
        {
            UserProfile userProfile = new UserProfile()
            {
                UserName = userName,
                UserSurname = userSurname,
                UserEmail = userEmail,
                UserBio = userBio,
                UserPhone = userPhone,
                UserImage = userImage
            };

            _dbConnection.Insert(userProfile);
        }
        public void UpdateUserProfile(UserProfile user)
        {
            _dbConnection.Update(user);
        }
        public UserProfile GetUserById(int id)
        {
            UserProfile user = _dbConnection.Table<UserProfile>().Where(x => x.UserID == id).FirstOrDefault();

            if (user != null)
                _dbConnection.GetChildren(user, true);

            return user;
        }
    }
}
