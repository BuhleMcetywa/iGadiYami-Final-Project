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

            // Onion & Onion Disease
            if (_dbConnection.Table<Onion>().Count() == 0)
            {
                Onion onion = new Onion()
                {
                    Name = "Onion",
                    SoilType = "Fine textured soil with sand & add nitrogen fertiliser.",
                    WaterIntake = "•\tOnions require consistent watering. Aim for at least 1 inch of water per week (including rain). Overwatering can lead to disease and bulb rot.",
                    SoilPrep = "•\tMix aged manure or compost into the soil in the fall or early spring to improve texture. •\tOnion grows best in an area that has full sun, loose, well-drained, fertile, sandy-loam to silt-loam soil with plenty of organic matter.",
                    TimeToPlant = "•\tIn spring, plant onion sets outdoors as soon as the ground can be worked, usually in late March or April, when temperatures are no longer likely to dip below 28°F (-2°C). •\tStart onion seeds indoors about 6 weeks before transplanting to the ground (once the soil is at least 50°F)."
                };
                _dbConnection.Insert(onion);
            }
            if (_dbConnection.Table<OnionDisease>().Count() == 0)
            {
                List<OnionDisease> onionDiseases = new List<OnionDisease>()
                {
                    new OnionDisease()
                    {
                        DiseaseName = "Botrytis Blight",
                        DiseaseDescription = "",
                        DiseaseCauses = "caused by Botrytis squamosa, this pathogen favours cool, moist conditions and the infection starts with elongated white spots",
                        DiseaseControlMessures = "destroy onion or debris cull piles to reduces sources of inoculum, optimize plant row orientation and spacing to enhance air movement, reduce leaf wetness, implent a preventative fungicide spray program to manage the disease."
                    },
                    new OnionDisease()
                    {
                        DiseaseName = "Botrytis neck rot",
                        DiseaseDescription = "",
                        DiseaseCauses = "disease is caused by prolonged exposure to wet conditions, spreads most rapidly during moderate temperatures with high humidity, rainfall or overhead irrigation. Storing uncured onions at temperatures and humidity that are too high can promote disease development and spread.",
                        DiseaseControlMessures = "Adjust plant spacing and row orientation to obtain the best air movement through the plants, avoid injury to the onion neck and damage to the bulbs especially during harvest. Field applications of fungicides prior to harvest may reduce severity."
                    },
                    new OnionDisease()
                    {
                        DiseaseName = "Downy mildew",
                        DiseaseDescription = "",
                        DiseaseCauses = "Caused by the fungal disease Peronspora destructor that thrives in cool, humid conditions. Appears as pale green or yellow patches on the leaves which later turn brown",
                        DiseaseControlMessures = "Ensure good airflow, proper spacing between crops and fungicide treatments."
                    },
                    new OnionDisease()
                    {
                        DiseaseName = "Purple blotch",
                        DiseaseDescription = "",
                        DiseaseCauses = "Caused by the fungus Alternarria porria, pathogen thrives in warm, moist conditions.",
                        DiseaseControlMessures = "Applying a broad spectrum protective fungicides before infection can provide good protection, crop rotation is recommended after an outbreak, try to minimize leaf wetness by using  surface irrigation instead of sprinkler irrigation, ensure good field drainage and maintain correct plant spacing."
                    }
                };
                _dbConnection.InsertAll(onionDiseases);
            }
        }
    }
}
