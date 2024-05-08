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
                    SoilType = "Fine textured soil with sand",
                    WaterIntake = "•\tCarrots require consistent watering. Aim for at least 1 inch of water per week (including rain). Overwatering can lead to disease and root rot.",
                    SoilPrep = "•\tMix aged manure or compost into the soil in the fall or early spring to improve texture.",
                    TimeToPlant = "•\tIn cooler areas, the best time to plant carrots is from February to April and from August to October. In mild areas, they can be planted throughout the year. •\tBegin to sow the carrot seeds three weeks before the last spring frost."
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
                        DiseaseDescription = "",
                        DiseaseCauses = "The larvae of the carrot rust fly tunnel into the roots, causing damage and making the carrots unmarketable",
                        DiseaseControlMessures = "To control this pest, you can use floating row covers to prevent adult flies from laying eggs on the plants or consider using appropriate insecticides."
                    },
                    new CarrotDisease()
                    {
                        DiseaseName = "Alternaria Leaf Blight",
                        DiseaseDescription = "",
                        DiseaseCauses = "This fungal disease affects the leaves and stems of carrot plants. It causes dark, sunken lesions on the leaves and can lead to defoliation if left untreated.",
                        DiseaseControlMessures = "Crop rotation, proper sanitation, and the use of fungicides labeled for carrot diseases can help manage Alternaria leaf blight."
                    },
                    new CarrotDisease()
                    {
                        DiseaseName = "Root Knot Nematodes",
                        DiseaseDescription = "",
                        DiseaseCauses = "These microscopic worm-like organisms can cause galls or knots to form on the roots of carrot plants. Infected plants may show stunted growth and have reduced yields.",
                        DiseaseControlMessures = "Crop rotation, soil solarization, and the use of resistant carrot varieties are effective management strategies for root knot nematodes."
                    }
                };
                _dbConnection.InsertAll(carrotDiseases);
            }
        }
    }
}
