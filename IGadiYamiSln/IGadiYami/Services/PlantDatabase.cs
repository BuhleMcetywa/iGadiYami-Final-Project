using IGadiYami.Models.Diseases;
using IGadiYami.Models.Vegetable;
using IGadiYami.Models.Vegetable_Disease;
using IGadiYami.Models.Vegetable_Type;
using Microsoft.Maui.ApplicationModel;
using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IGadiYami.Services
{
    public class PlantDatabase : IPlantDatabase
    {
        private SQLiteConnection _dbConnection;
        public PlantDatabase()
        {
            _dbConnection = new SQLiteConnection(GetDatabasePath());
            _dbConnection.CreateTable<Disease>();
            _dbConnection.CreateTable<VegetableDisease>();
            _dbConnection.CreateTable<Vegetables>();
            _dbConnection.CreateTable<VegetableType>();
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
        }


        // Methods to use Data
       
    }
}
