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
    public class PlantDatabase : IPlantDatabase
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
            // Carrot & Carrot Diseases
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


            // Onion & Onion Diseases
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


            // Potato & Potato Diseases
            if (_dbConnection.Table<Potato>().Count() == 0)
            {
                Potato potato = new Potato()
                {
                    Name = "Potato",
                    SoilType = "For potatoes, having space to grow underground is crucial, and loam provides that room  while also being light enough for tubers to expand comfortably. So, loamy soil is like a cozy  home for potatoes, keeping them well-nourished, hydrated, and supported as they grow.",
                    WaterIntake = "Keep potato plants consistently moist by watering deeply, avoiding overhead watering, and  adjusting frequency based on weather and growth stages. Adjust your watering schedule  based on the growth stage of your potato plants. They need more water during tuber  formation and bulking stages, which typically occur about 3 to 4 weeks after planting. \r\n",
                    SoilPrep = " For potatoes, aim for a soil pH between 5.0 and 6.0, as this range provides optimal conditions for growth and nutrient uptake. Testing the soil pH before planting can help determine if any adjustments are necessary. Adding lime can raise pH if it's too low, while sulfur or elemental sulfur can lower it if it's too high. \r\n",
                    TimeToPlant = "The perfect planting window is typically between mid-August and mid-September. This  special time is called the potato planting season. It's when the soil is warm and cozy,  creating the ideal conditions for your potatoes to grow big and tasty! So, mark your calendar  and get ready to plant your potatoes for a bountiful harvest. \r\n"
                };
                _dbConnection.Insert(potato);
            }
            if (_dbConnection.Table<PotatoDisease>().Count() == 0)
            {
                List<PotatoDisease> potatoDiseases = new List<PotatoDisease>()
                {
                    new PotatoDisease()
                    {
                        DiseaseName = "Bacterial soft rot",
                        DiseaseDescription = "",
                        DiseaseCauses = "Bacterial soft rot is caused by various types of bacteria, with Erwinia carotovora being a common culprit. These bacteria can infect potatoes both in the ground and after harvest.",
                        DiseaseControlMessures = "To prevent bacterial soft rot in potatoes, start with disease-free seed potatoes and rotate crops with non-host plants. Keep fields clean by removing infected plants and debris, and avoid planting in areas with a history of the disease. Proper irrigation, soil drainage, and careful handling during harvest and storage are crucial, while considering chemical treatments and biological controls as additional options to manage the disease effectively.\r\n"
                    },
                    new PotatoDisease()
                    {
                        DiseaseName = "Blackleg disease",
                        DiseaseDescription = "",
                        DiseaseCauses = "Blackleg disease in potatoes is caused by pectolytic bacteria, specifically those in the genera Pectobacterium and Dickeya (formerly known as Erwinia)",
                        DiseaseControlMessures = "To prevent blackleg disease in potatoes, start with healthy seed potatoes and rotate crops with different plants each year. Keep fields clean, avoid overwatering, and choose resistant potato varieties when possible to minimize the risk of disease.\r\n"
                    },
                    new PotatoDisease()
                    {
                        DiseaseName = "Early blight",
                        DiseaseDescription = "",
                        DiseaseCauses = "Alternaria solani is the primary culprit behind early blight.  Early blight doesn’t require excessive moisture it can even persist during drought periods.\r\nThe fungus tends to attack weakened plants, especially those with insect damage or reduced vitality due to other factors.\r\nShaded and older leaves are more susceptible to infection than young, vigorous ones.",
                        DiseaseControlMessures = "To control early blight in potatoes, start by choosing potato varieties that resist the disease and rotate crops with different plants each season. Keep the potato patch clean by removing any infected leaves or debris, and water the plants at ground level to avoid splashing spores. If needed, apply natural or chemical fungicides according to instructions to further protect the plants from early blight.\r\n"
                    },
                    new PotatoDisease()
                    {
                        DiseaseName = "Late Blight",
                        DiseaseDescription = "",
                        DiseaseCauses = "Late blight in potatoes is caused by the airborne spores of the Phytophthora infestans fungus. This disease manifests as irregular dark lesions on the stems and leaves of potato plants and spreads quickly. Late blight is a sporadic disease and is more likely to develop in cool, wet conditions.",
                        DiseaseControlMessures = "To stop late blight in potatoes, pick resistant varieties and rotate crops yearly. Keep the potato area clean, removing any infected leaves promptly. Use fungicides during humid weather and water plants early in the day at the base to keep the foliage dry.\r\n"
                    },
                    new PotatoDisease()
                    {
                        DiseaseName = "Powdery scab disease",
                        DiseaseDescription = "",
                        DiseaseCauses = "The disease is caused by Spongospora subterranea and can lead to significant yield losses.\r\n\r\n",
                        DiseaseControlMessures = "To control powdery scab in potatoes, begin with disease-free seed potatoes, rotate crops, and maintain good field hygiene. Additionally, ensure proper soil drainage, monitor for early signs of the disease, and consider using resistant potato varieties if available.\r\n"
                    }
                };
                _dbConnection.InsertAll(potatoDiseases);
            }


            // Tomato & Tomato Diseases
            if (_dbConnection.Table<Tomato>().Count() == 0) 
            {
                Tomato tomato = new Tomato()
                {
                    Name = "Tomato",
                    SoilType = "Tomatoes grow best in sandy loam or loamy soil because it drains well but keeps moisture and\r\nnutrients. Adding compost or aged manure to the soil helps tomatoes grow healthy by giving them\r\nimportant nutrients and making the soil better. Avoid heavy clay soils because they hold too much\r\nwater, which can be bad for tomato roots. Test your soil regularly and add things to make it better\r\n\r\nfor growing tomatoes.",
                    WaterIntake = "Garden tomatoes typically require 1-2 inches of water a week. Tomato plants grown in containers need more water than garden tomatoes.",
                    SoilPrep = "Loosen the soil and remove any weeds. If the soil is poor, add compost or aged\r\nmanure to enrich it.",
                    TimeToPlant = "Tomatoes thrive in warm weather, requiring temperatures consistently above 10°C for optimal\r\ngrowth. Nighttime temperatures of 13°C or higher are necessary for fruit setting. Plant tomatoes\r\nwhen the soil temperature reaches around 16°C, ensuring it's warm enough by checking if you can\r\nkeep your finger in the soil for a full minute without discomfort. Avoid planting too early to prevent\r\ndamage from late frosts, selecting varieties with days-to-maturity shorter than the days until the\r\nexpected first frost. Additionally, while tomatoes enjoy sunlight, they struggle to set fruit when\r\ntemperatures exceed 29°C, and maintaining a humidity level between 65% to 85% fosters optimal\r\n\r\ngrowth."
                };
                _dbConnection.Insert(tomato);
            }
            if (_dbConnection.Table<TomatoDisease>().Count() == 0)
            {
                List<TomatoDisease> tomatoDiseases = new List<TomatoDisease>()
                {
                    new TomatoDisease()
                    {
                        DiseaseName = "Anthracnose",
                        DiseaseDescription = "",
                        DiseaseCauses = "Caused by several species of the fungus Colletotrichum. Ripe and overripe fruit are especially susceptible but the pathogen can infect green fruit with symptoms not developing until fruit begin to ripen. ",
                        DiseaseControlMessures = "To stop anthracnose in tomatoes, keep the area clean by removing infected plants and\r\nrotating crops each year. Choose resistant tomato types and water plants carefully to keep\r\nthe leaves dry. Apply mulch, consider using fungicides if needed, and regularly check for\r\n\r\nsigns of the disease."
                    },
                    new TomatoDisease()
                    {
                        DiseaseName = "Blossom End Rot",
                        DiseaseDescription = "",
                        DiseaseCauses = "Low calcium levels in the soil.\r\nSoil that is over- or underwatered.\r\nWide fluctuations in soil moisture.\r\nInconsistent watering.\r\nLow soil pH.\r\nExcessive nitrogen.",
                        DiseaseControlMessures = "To prevent blossom end rot in tomatoes, maintain consistent watering to avoid fluctuations\r\nin soil moisture. Ensure proper calcium levels in the soil through soil amendments or\r\nfertilizers containing calcium. Mulch around tomato plants to regulate soil temperature and\r\nmoisture, and avoid excessive nitrogen fertilization, which can interfere with calcium\r\n\r\nuptake."
                    },
                    new TomatoDisease()
                    {
                        DiseaseName = "Early blight",
                        DiseaseDescription = "",
                        DiseaseCauses = "Early blight is caused by the fugus Alternaria linariae and occurs anytime during growing seaso, the pathogen is favoured by high humidity and temperatures above 24 degrees celsius.",
                        DiseaseControlMessures = "To keep early blight away from tomatoes, use resistant varieties and rotate crops. Keep the\r\narea clean by removing infected leaves and debris, and space plants apart while mulching\r\nthe soil. Water at the base, prune for air flow, and consider using sprays if needed, while\r\n\r\nalways keeping an eye out for signs of the disease."
                    },
                    new TomatoDisease()
                    {
                        DiseaseName = "Late blight",
                        DiseaseDescription = "",
                        DiseaseCauses = "Caused by the oomycete pathogen Phytophthora infestans, the pathogen prefers wet conditions with humid temperatures that span over 3-5 days",
                        DiseaseControlMessures = "If you notice any signs of late blight (brown, gray, or purplish spots on leaves or stems),\r\npromptly remove and destroy the affected leaves. Late blight becomes more resistant to\r\n\r\ntreatment as it progresses, so early intervention is crucial."
                    },
                };
                _dbConnection.InsertAll(tomatoDiseases);
            }


            // Spinach & Spinach Dieases
            if (_dbConnection.Table<Spinach>().Count() == 0)
            {
                Spinach spinach = new Spinach()
                {
                    Name = "Spinach",
                    SoilType = "Spinach thrives best in loamy soil, which strikes a balance between drainage and moisture  retention. It provides a cozy home for spinach roots, allowing them to absorb nutrients  effectively. ",
                    WaterIntake = "Keep your spinach soil consistently moist, but not soggy, by watering deeply and regularly,  especially during dry periods. Avoid watering overhead to prevent wetting the leaves, which  can lead to disease. Adjust your watering schedule based on the growth stage of your  spinach. For example, during the growing stage, they may need more water. ",
                    SoilPrep = "In general, spinach needs around 1 to 1 1/2 inches of water per week. Spinach prefers well-drained, fertile soil. Mix in compost or well-rotted manure to enrich  the soil. Loosen the soil to a depth of 15-20 cm. ",
                    TimeToPlant = "Spinach grows best in cool weather, so it is perfect for planting in spring or fall. In spring, sow seeds  when the ground warms up to about 4°C. For fall planting, sow when the soil is 21°C or cooler.  Some gardeners can even grow spinach in winter by protecting it with a cold frame or mulch. When  spring comes and the soil reaches about 4°C. "
                };
                _dbConnection.Insert(spinach);
            }
            if (_dbConnection.Table<SpinachDisease>().Count() == 0)
            {
                List<SpinachDisease> spinachDiseases = new List<SpinachDisease>()
                {
                    new SpinachDisease()
                    {
                        DiseaseName = "Fusarium wilt",
                        DiseaseDescription = "",
                        DiseaseCauses = "Caused by a soil-borne fungal disease, noticeable by wilting, yellowing and stunting of plants",
                        DiseaseControlMessures = "Use disease-resistant spinach varieties, practice crop rotation."
                    },
                    new SpinachDisease()
                    {
                        DiseaseName = "Downy Mildew",
                        DiseaseDescription = "",
                        DiseaseCauses = "fungal diseases caused by Peronospora finosa can be identidied by yellow or pale green spots on the upper surface of the leaves and a grayish-purple growth on the undersides",
                        DiseaseControlMessures = "avoid overhead watering of crops, provide adequate spacing between plants for good air circulation."
                    },
                    new SpinachDisease()
                    {
                        DiseaseName = "White Rust",
                        DiseaseDescription = "",
                        DiseaseCauses = "A fungal disease, cuases raised, white pustules on the undersides of leaves and can lead to severe defoliation",
                        DiseaseControlMessures = "Practice crop rotation, remove infected plants to prevent the spread of white rust."
                    },
                    new SpinachDisease()
                    {
                        DiseaseName = "Anthracnose",
                        DiseaseDescription = "",
                        DiseaseCauses = "A fungal disease that affect spinach leaves and stems, causes dark, eater soaked lesions that turn tan or gray",
                        DiseaseControlMessures = "Avoid overcrowding, ensure good drainage in your growing area."
                    }
                };
                _dbConnection.InsertAll(spinachDiseases);
            }
        }


        // Methods to use Data
        // Carrot Methods
        public Carrot GetCarrotInformation()
        {
            Carrot carrot = _dbConnection.Table<Carrot>().FirstOrDefault();
            return carrot;
        }
        public CarrotDisease GetCarrotDiseaseByName(string diseaseName)
        {
            CarrotDisease carrotDisease = _dbConnection.Table<CarrotDisease>().FirstOrDefault(d => d.DiseaseName == diseaseName);
            return carrotDisease;
        }


        // Onion Methods
        public Onion GetOnionInformation()
        {
            Onion onion = _dbConnection.Table<Onion>().FirstOrDefault();
            return onion;
        }
        public OnionDisease GetOnionDiseaseByName(string diseaseName)
        {
            OnionDisease onionDisease = _dbConnection.Table<OnionDisease>().FirstOrDefault(d => d.DiseaseName == diseaseName);
            return onionDisease;
        }


        // Potato Methods
        public Potato GetPotatoInformation()
        {
            Potato potato = _dbConnection.Table<Potato>().FirstOrDefault();
            return potato;
        }
        public PotatoDisease GetPotatoDiseaseByName(string diseaseName)
        {
            PotatoDisease potatoDisease = _dbConnection.Table<PotatoDisease>().FirstOrDefault(d => d.DiseaseName == diseaseName);
            return potatoDisease;
        }


        // Spinach Methods
        public Spinach GetSpinachInformation()
        {
            Spinach spinach = _dbConnection.Table<Spinach>().FirstOrDefault();
            return spinach;
        }
        public SpinachDisease GetSpinachDiseaseByName(string diseaseName)
        {
            SpinachDisease spinachDisease = _dbConnection.Table<SpinachDisease>().FirstOrDefault(d => d.DiseaseName == diseaseName);
            return spinachDisease;
        }


        // Tomato Methods
        public Tomato GetTomatoInformation()
        {
            Tomato tomato = _dbConnection.Table<Tomato>().FirstOrDefault();
            return tomato;
        }
        public TomatoDisease GetTomatoDiseaseByName(string diseaseName)
        {
            TomatoDisease tomatoDisease = _dbConnection.Table<TomatoDisease>().FirstOrDefault(d => d.DiseaseName == diseaseName);
            return tomatoDisease;
        }
    }
}
