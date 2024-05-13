using IGadiYami.Models.User_Profile;
using IGadiYami.Views;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
