using IGadiYami.Models.Carrot;
using IGadiYami.Models.Onion;
using IGadiYami.Models.Potato;
using IGadiYami.Models.Spinach;
using IGadiYami.Models.Tomato;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGadiYami.Services
{
    internal class PlantDatabase : IPlantDatabase
    {
        private SQLiteConnection _dbConnection;
        public PlantDatabase()
        {
            _dbConnection = new SQLiteConnection(GetDatabasePath());
            _dbConnection.CreateTable<Carrot>();
            _dbConnection.CreateTable<CarrotDisease>();
            _dbConnection.CreateTable<Onion>();
            _dbConnection.CreateTable<OnionDisease>();
            _dbConnection.CreateTable<Potato>();
            _dbConnection.CreateTable<PotatoDisease>();
            _dbConnection.CreateTable<Spinach>();
            _dbConnection.CreateTable<SpinachDisease>();
            _dbConnection.CreateTable<Tomato>();
            _dbConnection.CreateTable<TomatoDisease>();
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
            // Carrot & Carrot Disease
            if (_dbConnection.Table<Carrot>().Count() == 0)
            {
                Carrot carrot = new Carrot()
                {
                    Name = "Carrot",
                    SoilType = "Test 1",
                    WaterIntake = "Test 2L",
                    SoilPrep = "Test 3 Prep",
                    TimeToPlant = "Test 4pm"
                };
                _dbConnection.Insert(carrot);
            }
            if (_dbConnection.Table<CarrotDisease>().Count() == 0)
            {
                List<CarrotDisease> carrotDiseases = new List<CarrotDisease>()
                {
                    new CarrotDisease()
                    {
                        DiseaseName = "Carrot Rust Fly",
                        DiseaseDescription = "Testing Disease",
                        DiseaseCauses = "Testing Causes",
                        DiseaseControlMessures = "Testing Control Measures"
                    },
                    new CarrotDisease()
                    {
                        DiseaseName = "Carrot Rust Fly 2",
                        DiseaseDescription = "Testing Disease 2",
                        DiseaseCauses = "Testing Causes 2",
                        DiseaseControlMessures = "Testing Control Measures 2"
                    },
                    new CarrotDisease()
                    {
                        DiseaseName = "Carrot Rust Fly 3",
                        DiseaseDescription = "Testing Disease 3",
                        DiseaseCauses = "Testing Causes 3",
                        DiseaseControlMessures = "Testing Control Measures 3"
                    }
                };
                _dbConnection.InsertAll(carrotDiseases);
            }
        }
    }
}
