using IGadiYami.Models;
using SQLite;
// using Windows.System;

namespace IGadiYami.Services
{
    public class UserDatabase : IUserDatabase
    {
        private SQLiteConnection _dbConnection;

        public UserDatabase()
        {
            _dbConnection = new SQLiteConnection(GetDatabasePath());
            _dbConnection.CreateTable<UserData>();
            SeedDatabase();
        }
        public string GetDatabasePath()
        {
            string fileName = "profiledatabase.db";
            string pathToDb = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return pathToDb + fileName;
        }
        public void SeedDatabase()
        {
            if (_dbConnection.Table<UserData>().Count() == 0)
            {
                UserData userData = new UserData()
                {
                    UserName = "TestName",
                    UserSurname = "TestSurname",
                    UserEmail = "Test@gmail.com",
                    UserPassword = "userPassword",
                    // UserPhoneNumber = "1234567890"
                };

                _dbConnection.Insert(userData);
            }
        }

        // Methods
        public void CreateUser(string userName, string userSurname, string userEmail, string userPassword)
        {
            UserData user = new UserData()
            {
                UserName = userName,
                UserSurname = userSurname,
                UserEmail = userEmail,
                UserPassword = userPassword,
                // UserPhoneNumber = userPhoneNumber
            };
            _dbConnection.Insert(user);
        }
        public void UpdateUser(int userId, string userName, string userSurname, string userEmail, string userPassword, string userPhoneNumber)
        {
            var userToUpdate = _dbConnection.Table<UserData>().FirstOrDefault(u => u.UserID == userId);

            if (userToUpdate != null)
            {
                userToUpdate.UserName = userName;
                userToUpdate.UserSurname = userSurname;
                userToUpdate.UserEmail = userEmail;
                userToUpdate.UserPassword = userPassword;
                // userToUpdate.UserPhoneNumber = userPhoneNumber;

                _dbConnection.Update(userToUpdate);
            }
        }
        public void DeleteUser(int userId)
        {
            var userToDelete = _dbConnection.Table<UserData>().FirstOrDefault(u => u.UserID == userId);

            if (userToDelete != null)
            {
                _dbConnection.Delete<UserData>(userId);
            }
        }
        public UserData GetUserById(int Id)
        {
            return _dbConnection.Table<UserData>().FirstOrDefault(u => u.UserID == Id);
        }

        public UserData GetUserByName(string name)
        {
            return _dbConnection.Table<UserData>().FirstOrDefault(u => u.UserName == name);
        }

        public bool VerifyUserPassword(string userEmail, string userPassword)
        {
            var user = _dbConnection.Table<UserData>().FirstOrDefault(u => u.UserEmail == userEmail);

            if (user != null)
            {
                user.UserEmail = userEmail;
                user.UserPassword = userPassword;
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
