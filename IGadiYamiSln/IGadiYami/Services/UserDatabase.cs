using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IGadiYami.Models;
using IGadiYami.Models.UserData;

namespace IGadiYami.Services
{
    public class UserDatabase : IUserDatabase
    {
        private SQLiteConnection _dbConnection;

        public UserDatabase()
        {
            _dbConnection = new SQLiteConnection(GetDatabasePath());
            _dbConnection.CreateTable<UserData>();
        }
        public string GetDatabasePath()
        {
            string fileName = "profiledatabase.db";
            string pathToDb = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return pathToDb + fileName;
        }
        public void SeedDatabase()
        {

        }
    }
}
