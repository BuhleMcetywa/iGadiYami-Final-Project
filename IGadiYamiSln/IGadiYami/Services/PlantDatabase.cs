using IGadiYami.Models.Carrot;
using IGadiYami.Models.Onion;
using IGadiYami.Models.Potato;
using IGadiYami.Models.Spinach;
using IGadiYami.Models.Tomato;
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
                    SoilType = "Carrots grow best in well-drained soil that is acidic (6.5 to 7.5 on the pH scale).",
					WaterIntake = "•\tCarrots require consistent watering. Aim for at least 1 inch of water per week (including rain). Overwatering can lead to disease and root rot.",
					SoilPrep = "Do not work compost or manure into the soil just before planting.\r\nRich soil will result in excessive leaf growth and forked, hairy, rough roots.\r\nBeds should be 1m wide, separated by paths 40cm to 50cm wide.\r\nPrepare the soil in the beds to a depth of 30cm.\r\nRemove all clods and stones. Beds must be raised for good drainage.",
					TimeToPlant = "\nCarrots can be planted in early spring or late autumn, depending on your climate. Spring is the best time to plant carrots in most parts of South Africa.Autumn planting may be possible in colder parts of the country, but is not recommended for most areas.",
					CommonDiseases = "•\nCarrot Rust Fly •\nAlternaria Leaf Blight •\nRoot Knot Nematodes",
                    HowToPlant = "Sow the seeds directly in the beds.\r\nMake small furrows one fingernail (1cm) deep and about two or three hand widths (20cm to 30cm) apart.\r\nSow the seeds about 2cm apart in the furrows.\r\nWater the beds well after sowing.\r\nIn hot, dry weather, cover the rows with a thin layer of grass clippings until the seeds emerge after seven to 14 days.\r\nRemove the grass and spread thinly between the rows.",
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
                        DiseaseControlMeasures = "To control this pest, you can use floating row covers to prevent adult flies from laying eggs on the plants or consider using appropriate insecticides."
                    },
                    new CarrotDisease()
                    {
                        DiseaseName = "Alternaria Leaf Blight",
                        DiseaseDescription = "",
                        DiseaseCauses = "This fungal disease affects the leaves and stems of carrot plants. It causes dark, sunken lesions on the leaves and can lead to defoliation if left untreated.",
                        DiseaseControlMeasures = "Crop rotation, proper sanitation, and the use of fungicides labeled for carrot diseases can help manage Alternaria leaf blight."
                    },
                    new CarrotDisease()
                    {
                        DiseaseName = "Root Knot Nematodes",
                        DiseaseDescription = "",
                        DiseaseCauses = "These microscopic worm-like organisms can cause galls or knots to form on the roots of carrot plants. Infected plants may show stunted growth and have reduced yields.",
                        DiseaseControlMeasures = "Crop rotation, soil solarization, and the use of resistant carrot varieties are effective management strategies for root knot nematodes."
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
                    SoilType = "Seedbed soil needs to have a fine texture",
                    WaterIntake = "Onion roots are concentrated in the upper 30 mm of soil and for this reason the soil must be kept moist. \n Do not water onions for three weeks prior to harvesting.",
                    SoilPrep = "\tSeedbed soil needs to have a fine texture. \nSeeds should be sown in rows to ensure enough ventilation and facilitate weed control. \nFurrows should be 15 cm apart and the seed should be sown at a depth of 10mm to 15mm. \n Sowing densities should be between 1500 and 2500 seeds per 1m^2. \nIf the temperature is high at this time, cover the seeded area with a thin layer of grass mulch. \nRemove this mulch when the plants start to appear 7 to 14 days after sowing.\nWhen the seedlings are 8mm to 9mm in diameter and 12 cm to 20cm in height they are ready to transplant.",
                    TimeToPlant = "•\tIn spring, plant onion sets outdoors as soon as the ground can be worked, usually in late March or April, when temperatures are no longer likely to dip below 28°F (-2°C). •\tStart onion seeds indoors about 6 weeks before transplanting to the ground (once the soil is at least 50°F).",
                    CommonDiseases="•\tBotrytis Blight •\tBotrytis neck rot •\tDowny mildew •\tPurple blotch",
                    HowToPlant= "\nPlants should be spaced 8 to 10 cm apart in rows that are 20 to 25 cm apart. \n This is between 50 and 60 plants per m². \nTo transplant, score furrows 2cm to 4cm deep in the ground and lay the white part of the seedling in the furrow. \n Don’t trim the leaves.\n Cover the roots with a rake and compact the soil around them. Do not plant the seedlings too deep as this could cause bulbs to become elongated. \n Keep the soil moist for five days, once the plants are in the field to allow the root system to settle", 
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
                        DiseaseControlMeasures = "destroy onion or debris cull piles to reduces sources of inoculum, optimize plant row orientation and spacing to enhance air movement, reduce leaf wetness, implent a preventative fungicide spray program to manage the disease."
                    },
                    new OnionDisease()
                    {
                        DiseaseName = "Botrytis neck rot",
                        DiseaseDescription = "",
                        DiseaseCauses = "disease is caused by prolonged exposure to wet conditions, spreads most rapidly during moderate temperatures with high humidity, rainfall or overhead irrigation. Storing uncured onions at temperatures and humidity that are too high can promote disease development and spread.",
                        DiseaseControlMeasures = "Adjust plant spacing and row orientation to obtain the best air movement through the plants, avoid injury to the onion neck and damage to the bulbs especially during harvest. Field applications of fungicides prior to harvest may reduce severity."
                    },
                    new OnionDisease()
                    {
                        DiseaseName = "Downy mildew",
                        DiseaseDescription = "",
                        DiseaseCauses = "Caused by the fungal disease Peronspora destructor that thrives in cool, humid conditions. Appears as pale green or yellow patches on the leaves which later turn brown",
                        DiseaseControlMeasures = "Ensure good airflow, proper spacing between crops and fungicide treatments."
                    },
                    new OnionDisease()
                    {
                        DiseaseName = "Purple blotch",
                        DiseaseDescription = "",
                        DiseaseCauses = "Caused by the fungus Alternarria porria, pathogen thrives in warm, moist conditions.",
                        DiseaseControlMeasures = "Applying a broad spectrum protective fungicides before infection can provide good protection, crop rotation is recommended after an outbreak, try to minimize leaf wetness by using  surface irrigation instead of sprinkler irrigation, ensure good field drainage and maintain correct plant spacing."
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
                    TimeToPlant = "The perfect planting window is typically between mid-August and mid-September. This  special time is called the potato planting season. It's when the soil is warm and cozy,  creating the ideal conditions for your potatoes to grow big and tasty! So, mark your calendar  and get ready to plant your potatoes for a bountiful harvest. \r\n",
                    CommonDiseases = "•\tBacterial soft rot •\tBlackleg disease •\tEarly blight •\tLate Blight •\tPowdery scab disease",
                    HowToPlant = "Step 1: Get Your Potatoes \r\nGet small, healthy potatoes that are not rotten or diseased. \r\nStep 2: Let Them Sprout \r\nLeave your potatoes in a cool, dry place until they grow little shoots, about 1 cm long. \r\nStep 3: Prep Your Soil  \r\nDig up your garden soil and mix in some compost or old animal manure to make it nice and rich. \r\nStep 4: Plant Your Potatoes  \r\nDig a shallow trench about as deep as your hand and place your sprouted potatoes in it, about a  hand's width apart. Cover them with soil. \r\nStep 5: Keep Mounding Soil  \r\nAs the potato plants grow, cover the base with soil to protect the sprouts. Keep doing this every few  weeks. \r\nStep 6: Water Them Regularly\r\nMake sure the soil is always moist, but not soaking wet. Water them when the soil feels dry. \r\nStep 7: Try Different Methods  \r\nIf you're short on space, you can try growing potatoes in a container or using a no-dig method. Just  make sure they have enough room to grow. \r\nStep 8: Harvest Your Potatoes \r\nAfter about 15-20 weeks (about 4 and a half months), your potatoes should be ready to harvest. Dig  them up carefully so you don't damage them. \r\nStep 9: Plant with Friends, Rotate Crops \r\nPlant your potatoes near plants like peas and beans, but keep them away from cucumbers,  pumpkins, and tomatoes. Change where you plant them each year to keep your soil healthy. \r\nStep 10: Avoid Chemicals and Harmful Materials \r\nDon't use fertilizers with heavy metals and avoid using old tires to grow your potatoes as they can  be harmful.\r\n",
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
                        DiseaseControlMeasures = "To prevent bacterial soft rot in potatoes, start with disease-free seed potatoes and rotate crops with non-host plants. Keep fields clean by removing infected plants and debris, and avoid planting in areas with a history of the disease. Proper irrigation, soil drainage, and careful handling during harvest and storage are crucial, while considering chemical treatments and biological controls as additional options to manage the disease effectively.\r\n"
                    },
                    new PotatoDisease()
                    {
                        DiseaseName = "Blackleg disease",
                        DiseaseDescription = "",
                        DiseaseCauses = "Blackleg disease in potatoes is caused by pectolytic bacteria, specifically those in the genera Pectobacterium and Dickeya (formerly known as Erwinia)",
                        DiseaseControlMeasures = "To prevent blackleg disease in potatoes, start with healthy seed potatoes and rotate crops with different plants each year. Keep fields clean, avoid overwatering, and choose resistant potato varieties when possible to minimize the risk of disease.\r\n"
                    },
                    new PotatoDisease()
                    {
                        DiseaseName = "Early blight",
                        DiseaseDescription = "",
                        DiseaseCauses = "Alternaria solani is the primary culprit behind early blight.  Early blight doesn’t require excessive moisture it can even persist during drought periods.\r\nThe fungus tends to attack weakened plants, especially those with insect damage or reduced vitality due to other factors.\r\nShaded and older leaves are more susceptible to infection than young, vigorous ones.",
                        DiseaseControlMeasures = "To control early blight in potatoes, start by choosing potato varieties that resist the disease and rotate crops with different plants each season. Keep the potato patch clean by removing any infected leaves or debris, and water the plants at ground level to avoid splashing spores. If needed, apply natural or chemical fungicides according to instructions to further protect the plants from early blight.\r\n"
                    },
                    new PotatoDisease()
                    {
                        DiseaseName = "Late Blight",
                        DiseaseDescription = "",
                        DiseaseCauses = "Late blight in potatoes is caused by the airborne spores of the Phytophthora infestans fungus. This disease manifests as irregular dark lesions on the stems and leaves of potato plants and spreads quickly. Late blight is a sporadic disease and is more likely to develop in cool, wet conditions.",
                        DiseaseControlMeasures = "To stop late blight in potatoes, pick resistant varieties and rotate crops yearly. Keep the potato area clean, removing any infected leaves promptly. Use fungicides during humid weather and water plants early in the day at the base to keep the foliage dry.\r\n"
                    },
                    new PotatoDisease()
                    {
                        DiseaseName = "Powdery scab disease",
                        DiseaseDescription = "",
                        DiseaseCauses = "The disease is caused by Spongospora subterranea and can lead to significant yield losses.\r\n\r\n",
                        DiseaseControlMeasures = "To control powdery scab in potatoes, begin with disease-free seed potatoes, rotate crops, and maintain good field hygiene. Additionally, ensure proper soil drainage, monitor for early signs of the disease, and consider using resistant potato varieties if available.\r\n"
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
                    TimeToPlant = "Tomatoes thrive in warm weather, requiring temperatures consistently above 10°C for optimal\r\ngrowth. Nighttime temperatures of 13°C or higher are necessary for fruit setting. Plant tomatoes\r\nwhen the soil temperature reaches around 16°C, ensuring it's warm enough by checking if you can\r\nkeep your finger in the soil for a full minute without discomfort. Avoid planting too early to prevent\r\ndamage from late frosts, selecting varieties with days-to-maturity shorter than the days until the\r\nexpected first frost. Additionally, while tomatoes enjoy sunlight, they struggle to set fruit when\r\ntemperatures exceed 29°C, and maintaining a humidity level between 65% to 85% fosters optimal\r\n\r\ngrowth.",
                    CommonDiseases = "•\tAnthracnose •\tBlossom End Rot •\tEarly blight •\tLate blight",
                    HowToPlant = "Choose a Sunny Spot:\r\nPick a sunny spot in your garden with well-draining soil.\r\n2. Prepare the Soil:\r\nLoosen the soil and remove any weeds. If the soil is poor, add compost or aged\r\nmanure to enrich it.\r\n3. Spacing:\r\nSpace tomato plants about 18 to 36 inches apart to allow for proper growth and airflow.\r\n4. Planting:\r\nDig a hole slightly deeper than the root ball of your tomato plant. Place the plant in the\r\nhole, gently cover the roots with soil, and pat it down lightly.\r\n5. Support:\r\nIf you're planting indeterminate varieties (which grow tall), install stakes or cages to support\r\nthe plants as they grow.\r\n6. Pruning:\r\nOptionally, you can prune suckers (small shoots that grow between the main stem and\r\n\r\nbranches) to promote airflow and fruit production.\r\n7. Harvesting:\r\nHarvest ripe tomatoes when they have developed their full color and are firm to the touch.",
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
                        DiseaseControlMeasures = "To stop anthracnose in tomatoes, keep the area clean by removing infected plants and\r\nrotating crops each year. Choose resistant tomato types and water plants carefully to keep\r\nthe leaves dry. Apply mulch, consider using fungicides if needed, and regularly check for\r\n\r\nsigns of the disease."
                    },
                    new TomatoDisease()
                    {
                        DiseaseName = "Blossom End Rot",
                        DiseaseDescription = "",
                        DiseaseCauses = "Low calcium levels in the soil.\r\nSoil that is over- or underwatered.\r\nWide fluctuations in soil moisture.\r\nInconsistent watering.\r\nLow soil pH.\r\nExcessive nitrogen.",
                        DiseaseControlMeasures = "To prevent blossom end rot in tomatoes, maintain consistent watering to avoid fluctuations\r\nin soil moisture. Ensure proper calcium levels in the soil through soil amendments or\r\nfertilizers containing calcium. Mulch around tomato plants to regulate soil temperature and\r\nmoisture, and avoid excessive nitrogen fertilization, which can interfere with calcium\r\n\r\nuptake."
                    },
                    new TomatoDisease()
                    {
                        DiseaseName = "Early blight",
                        DiseaseDescription = "",
                        DiseaseCauses = "Early blight is caused by the fugus Alternaria linariae and occurs anytime during growing seaso, the pathogen is favoured by high humidity and temperatures above 24 degrees celsius.",
                        DiseaseControlMeasures = "To keep early blight away from tomatoes, use resistant varieties and rotate crops. Keep the\r\narea clean by removing infected leaves and debris, and space plants apart while mulching\r\nthe soil. Water at the base, prune for air flow, and consider using sprays if needed, while\r\n\r\nalways keeping an eye out for signs of the disease."
                    },
                    new TomatoDisease()
                    {
                        DiseaseName = "Late blight",
                        DiseaseDescription = "",
                        DiseaseCauses = "Caused by the oomycete pathogen Phytophthora infestans, the pathogen prefers wet conditions with humid temperatures that span over 3-5 days",
                        DiseaseControlMeasures = "If you notice any signs of late blight (brown, gray, or purplish spots on leaves or stems),\r\npromptly remove and destroy the affected leaves. Late blight becomes more resistant to\r\n\r\ntreatment as it progresses, so early intervention is crucial."
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
                    TimeToPlant = "Spinach grows best in cool weather, so it is perfect for planting in spring or fall. In spring, sow seeds  when the ground warms up to about 4°C. For fall planting, sow when the soil is 21°C or cooler.  Some gardeners can even grow spinach in winter by protecting it with a cold frame or mulch. When  spring comes and the soil reaches about 4°C. ",
                    CommonDiseases = "•\tFusarium wilt •\tDowny Mildew •\tWhite Rust •\tAnthracnose",
                    HowToPlant = "1. Choose the Right Spinach Variety: \r\nSpinach varieties differ in their growth rates and flavors. \r\nBaby spinach: Grows quickly and is harvested young. \r\nSavoy spinach: Has crinkled leaves and is more cold-tolerant. \r\nFlat-leaf spinach: Has smooth leaves and is great for cooking. \r\nObtain spinach seeds from a reputable source or garden center. \r\n2. Light: \r\nPlant spinach where it will receive full sun to partial shade. It needs at least 3-4 hours of  direct sun daily. \r\n3. Prepare the Soil: \r\nSpinach prefers well-drained, fertile soil. Mix in compost or well-rotted manure to enrich  the soil. Loosen the soil to a depth of 15-20 cm. \r\n4. Planting: \r\nSow spinach seeds directly into the ground or containers. Plant seeds about 1 inch apart in  rows. Cover the seeds with a thin layer of soil (about 1/4 inch deep). Water gently to keep  the soil consistently moist. \r\n5. Growing Conditions: \r\nSpinach thrives in cool weather. Plant in early spring or late summer. Choose a sunny to  partially shaded spot. Keep the soil consistently moist but not waterlogged. \r\n6. Thinning: \r\nOnce the seedlings emerge, thin them out. Leave about 10-15 cm of space between each \r\nplant. Use thinned seedlings in salads or as microgreens. \r\n7. Successive Planting: \r\nTo enjoy spinach throughout the season, plant new seeds every 2-3 weeks. This ensures a  continuous harvest. \r\n8. Companion Planting: \r\nPlant spinach near other cool season crops like lettuce, radishes, and carrots. Avoid planting it near beet orchard, as they may compete for nutrients. \r\n",
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
                        DiseaseControlMeasures = "Use disease-resistant spinach varieties, practice crop rotation."
                    },
                    new SpinachDisease()
                    {
                        DiseaseName = "Downy Mildew",
                        DiseaseDescription = "",
                        DiseaseCauses = "fungal diseases caused by Peronospora finosa can be identified by yellow or pale green spots on the upper surface of the leaves and a grayish-purple growth on the undersides",
                        DiseaseControlMeasures = "avoid overhead watering of crops, provide adequate spacing between plants for good air circulation."
                    },
                    new SpinachDisease()
                    {
                        DiseaseName = "White Rust",
                        DiseaseDescription = "",
                        DiseaseCauses = "A fungal disease, causes raised, white pustules on the undersides of leaves and can lead to severe defoliation",
                        DiseaseControlMeasures = "Practice crop rotation, remove infected plants to prevent the spread of white rust."
                    },
                    new SpinachDisease()
                    {
                        DiseaseName = "Anthracnose",
                        DiseaseDescription = "",
                        DiseaseCauses = "A fungal disease that affect spinach leaves and stems, causes dark, eater soaked lesions that turn tan or gray",
                        DiseaseControlMeasures = "Avoid overcrowding, ensure good drainage in your growing area."
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
