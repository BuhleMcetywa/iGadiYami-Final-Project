using IGadiYami.Models;

using SQLite;


namespace IGadiYami.Services
{
	public class PlantDatabase
    {
        private SQLiteConnection _dbConnection;
        public PlantDatabase()
        {
            _dbConnection = new SQLiteConnection(GetDatabasePath());
            _dbConnection.CreateTable<Disease>();
            _dbConnection.CreateTable<VegetableDisease>();
            _dbConnection.CreateTable<Vegetable>();
            _dbConnection.CreateTable<VegetableType>();
            _dbConnection.CreateTable<CropTracking>();
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
            // Crop Tracking Feature
            if (_dbConnection.Table<CropTracking>().Count() == 0)
            {
                CropTracking crop = new CropTracking()
                {
                    CropName = "Tomatoes",
                    PlantDate = "01/01/2024",
                    WaterAmount = "2L",
                    GrowthAmount = "3 inch",
                    Notes = "testing",
                };
                _dbConnection.Insert(crop);

                CropTracking crop1 = new CropTracking()
                {
                    CropName = "Tomatoes",
                    PlantDate = "01/01/2024",
                    WaterAmount = "2L",
                    GrowthAmount = "3 inch",
                    Notes = "testing",
                };
                _dbConnection.Insert(crop1);

                CropTracking crop2 = new CropTracking()
                {
                    CropName = "Tomatoes",
                    PlantDate = "01/01/2024",
                    WaterAmount = "2L",
                    GrowthAmount = "3 inch",
                    Notes = "testing",
                };
                _dbConnection.Insert(crop2);
            }
            //this table you use to access the specific vegetable you want to plant
            if (_dbConnection.Table<Vegetable>().Count() == 0)
            {
                Vegetable vegetables = new Vegetable()
                {
                    Name = "Tomatoes",
                    SoilType = "Tomatoes grow best within a soil pH range of 6.0 to 6.8. This acidity level provides an optimal\r\n\r\nenvironment for their growth and productivity.Tomatoes grow best in sandy loam or loamy soil because it drains well but keeps moisture and\r\nnutrients.",
                    WaterIntake = "Water the plants thoroughly after planting to help them establish roots. Water regularly,\r\nkeeping the soil consistently moist but not waterlogged. Avoid overwatering, as it can\r\npromote the growth of fungal diseases. Water the base of the plants early in the day to\r\nallow foliage to dry before evening.",
                    SoilPrep = "Tomatoes thrive in warm weather, requiring temperatures consistently above 10°C for optimal growth\\r\\n. Nighttime temperatures of 13°C or higher are necessary for fruit setting. Plant tomatoes\\r\\nwhen the soil temperature reaches around 16°C, ensuring it's warm enough by checking if you can\\r\\nkeep your finger in the soil for a full minute without discomfort. Avoid planting too early to prevent\\r\\ndamage from late frosts, selecting varieties with days-to-maturity shorter than the days until the\\r\\nexpected first frost. Additionally, while tomatoes enjoy sunlight, they struggle to set fruit when\\r\\ntemperatures exceed 29°C, and maintaining a humidity level between 65% to 85% fosters optimal\\r\\n\\r\\ngrowth.\",",
                    TimeToPlant = "Tomatoes love warm weather, and in most of South Africa, are grown in summer.",
                    HowToPlant = "Choose a Sunny Spot:\r\nPick a sunny spot in your garden with well-draining soil.\r\n2. Prepare the Soil:\r\nLoosen the soil and remove any weeds. If the soil is poor, add compost or aged\r\nmanure to enrich it.\r\n3. Spacing:\r\nSpace tomato plants about 18 to 36 inches apart to allow for proper growth and airflow.\r\n4. Planting:\r\nDig a hole slightly deeper than the root ball of your tomato plant. Place the plant in the\r\nhole, gently cover the roots with soil, and pat it down lightly.\r\n5. Support:\r\nIf you're planting indeterminate varieties (which grow tall), install stakes or cages to support\r\nthe plants as they grow.\r\n6. Pruning:\r\nOptionally, you can prune suckers (small shoots that grow between the main stem and\r\n\r\nbranches) to promote airflow and fruit production.\r\n7. Harvesting:\r\nHarvest ripe tomatoes when they have developed their full color and are firm to the touch.",
                    Image = "tomato.jpg",
                    DescriptionOfVeg = "Tomatoes are juicy, red fruits often mistaken for vegetables. They are rich in vitamins and antioxidants, making them a healthy addition to any meal. Tomatoes can be enjoyed fresh in salads, cooked in sauces, or used as a base for soups and stews.",
                    CommonDiseases = "Anthracnose Disease \r\nBlossom End Rot Disease\r\nEarly blight Disease\r\nLate blight Disease\r\n\r\n",
                    VegetableColor = "#C42D09",
                    VegButtonColor = "#006838",
                };
                _dbConnection.Insert(vegetables);

                vegetables = new Vegetable()
                {
                    Name = "Onion",
                    SoilType = "Onions will grow in almost any kind of soil, from sandy loams to heavy clay. If the soil is heavy, work in some compost or manure to help it retain moisture. Onions prefer a slightly acidic soil, and a pH of 5,5 to 6,5 is good.",
                    WaterIntake = "Water the seedlings regularly: \r\n\r\nfirst week – twice a day\r\nsecond week – once a day\r\nthird week and on – three times a week.",
                    SoilPrep = "Work the soil deeply with a fork and apply a handful of recommended chemical fertiliser to every square metre of the soil surface. If using kraal manure or compost, apply about four handfuls to every square metre a few weeks before planting. Work the fertiliser, manure or compost into the soil with a fork. Rake flat and remove large clods and stones.",
                    TimeToPlant = "In South Africa, the best time to plant onions is typically during autumn or early winter, depending on your region. Aim for the period between April and March or July to October. However, with proper moisture and temperature management, you can grow onions year-round.",
                    HowToPlant = "Grow onions by direct seeding or from seedlings. Make furrows about 20cm to 30cm apart and transplant the seedlings 10cm apart in the furrows. This way, they shouldn’t need thinning. Dig a small hole for each seedling and place its roots downwards in the hole. Cover the seedlings with soil so that the tip of the neck just shows above the soil surface.",
                    Image = "onions.jpg",
                    DescriptionOfVeg = "Onions are versatile vegetables known for their pungent flavor and strong aroma. They come in various colors, including white, yellow, and red, each adding a unique taste to dishes. Onions can be eaten raw, cooked, or pickled, and they are a staple ingredient in many cuisines worldwide.",
                    CommonDiseases = "Botrytis Blight Disease\r\nBotrytis neck rot Disease\r\nDowny mildew Disease\r\nPurple blotch Disease\r\n",
                    VegetableColor= "#ba5c21",
                    VegButtonColor= "#006838",

                };
                _dbConnection.Insert(vegetables);

                vegetables = new Vegetable()
                {
                    Name = "Potato",
                    SoilType = "For potatoes, aim for a soil pH between 5.0 and 6.0, as this range provides optimal conditions for growth and nutrient uptake.For potatoes, having space to grow underground is crucial, and loam provides that room  while also being light enough for tubers to expand comfortably. So, loamy soil is like a cozy  home for potatoes, keeping them well-nourished, hydrated, and supported as they grow. \r\n",
                    WaterIntake = "Potatoes require consistent moisture for healthy tuber development. Water the plants regularly, aiming to keep the soil evenly moist but not waterlogged. Provide deep watering once or twice a week, depending on weather conditions, to ensure proper hydration.",
                    SoilPrep = " Potatoes prefer loose, well-drained soil with good fertility. Prepare the soil by removing weeds, breaking up clumps, and incorporating organic matter, such as compost or well-rotted manure, to improve its structure and nutrient content.",
                    TimeToPlant = "The perfect planting window is typically between mid-August and mid-September. This  special time is called the potato planting season. It's when the soil is warm and cozy,  creating the ideal conditions for your potatoes to grow big and tasty! ",
                    HowToPlant = "Step 1: Get Your Potatoes \r\nGet small, healthy potatoes that are not rotten or diseased. \r\nStep 2: Let Them Sprout \r\nLeave your potatoes in a cool, dry place until they grow little shoots, about 1 cm long. \r\nStep 3: Prep Your Soil  \r\nDig up your garden soil and mix in some compost or old animal manure to make it nice and rich. \r\nStep 4: Plant Your Potatoes  \r\nDig a shallow trench about as deep as your hand and place your sprouted potatoes in it, about a  hand's width apart. Cover them with soil. \r\nStep 5: Keep Mounding Soil  \r\nAs the potato plants grow, cover the base with soil to protect the sprouts. Keep doing this every few  weeks. \r\nStep 6: Water Them Regularly\r\nMake sure the soil is always moist, but not soaking wet. Water them when the soil feels dry. \r\nStep 7: Try Different Methods  \r\nIf you're short on space, you can try growing potatoes in a container or using a no-dig method. Just  make sure they have enough room to grow. \r\nStep 8: Harvest Your Potatoes \r\nAfter about 15-20 weeks (about 4 and a half months), your potatoes should be ready to harvest. Dig  them up carefully so you don't damage them. \r\n",
                    Image = "potatoes.jpeg",
                    DescriptionOfVeg = "Potatoes are versatile tubers that are a staple food in many cultures. They come in various shapes, sizes, and colors, including russet, red, and purple. Potatoes can be baked, boiled, mashed, or fried, and they provide a good source of carbohydrates, potassium, and vitamin C",
                    CommonDiseases = "Bacterial soft rot Disease\r\nBlackleg Disease\r\nEarly blight Disease\r\nLate Blight Disease\r\nPowdery Scab Disease Disease\r\n\r\n",
                    VegetableColor = "#615335",
                    VegButtonColor = "#006838",

                };
                _dbConnection.Insert(vegetables);

                vegetables = new Vegetable()
                {
                    Name = "Carrot",
                    SoilType = "Carrots prefer well-drained soil that is slightly acidic with a ph of 6-7",
                    WaterIntake = "",
                    SoilPrep = " Make sure the soil is well-drained and amend with plenty of organic matter before planting",
                    TimeToPlant = "Carrots are a versatile vegetable and can be grown in a variety of climates, but they are especially well-suited to growing in warm climates. Carrots can be planted in early spring or late fall, depending on your climate. Spring is the best time to plant carrots in most parts of South Africa. Autumn planting may be possible in colder parts of the country, but is not recommended for most areas.",
                    HowToPlant = "To plant carrots:\r\n1. Choose a well-drained soil that is slightly acidic (6-7 pH).\r\n2. Dig a hole twice as wide and as deep as the root ball you plan to use, making sure the hole is lined with fresh soil before planting.\r\n3. Remove the carrot’s green taproot by slicing it just above the ground with a sharp knife. If the carrot has a long taproot, cut it into shorter pieces before planting.\r\n4. Place the carrot root ball (with any attached roots) into the prepared hole, making sure it is centered within the circle of dirt created by your gardening trowel. Water thoroughly and cover with fresh soil.",
                    Image = "carrots.jpeg",
                    DescriptionOfVeg = "Carrots are root vegetables known for their bright orange color and sweet, earthy flavor. They are an excellent source of beta-carotene, fiber, and various vitamins. Carrots can be eaten raw as a crunchy snack, cooked in a variety of dishes, or juiced for a ,healthy drink.",
                    CommonDiseases = "Carrot Rust Fly Disease\r\nAlternaria Leaf Blight Disease\r\nRoot Knot Nematodes Disease\r\n",
                    VegetableColor = "#F8861D",
                    VegButtonColor = "#006838",
                };

                _dbConnection.Insert(vegetables);

                vegetables = new Vegetable()
                {
                    Name = "Spinach",
                    SoilType = "Spinach generally prefers a slightly acidic to neutral soil pH ranging from 6.0 to 7.0. This pH range provides optimal conditions for nutrient uptake and overall plant health. However, spinach is adaptable and can tolerate a wider pH range, but extremes on either end (highly acidic or highly alkaline soils) may lead to nutrient deficiencies or toxicity, affecting plant growth and yield. Therefore, maintaining the soil pH within the recommended range is crucial for successful spinach cultivation.\r\nSpinach thrives best in loamy soil, which strikes a balance between drainage and moisture  retention. It provides a cozy home for spinach roots, allowing them to absorb nutrients  effectively. \r\nSandy soil drains quickly, preventing waterlogging, but it requires regular watering to keep  spinach hydrated. \r\n",
                    WaterIntake = "Keep your spinach soil consistently moist, but not soggy, by watering deeply and regularly,  especially during dry periods. Avoid watering overhead to prevent wetting the leaves, which  can lead to disease. Adjust your watering schedule based on the growth stage of your  spinach. For example, during the growing stage, they may need more water. \r\n",
                    SoilPrep = "Spinach prefers well-drained, fertile soil. Mix in compost or well-rotted manure to enrich  the soil. Loosen the soil to a depth of 15-20 cm. \r\n",
                    TimeToPlant = "Spinach grows best in cool weather, so it is perfect for planting in spring or autumn. In spring, sow seeds  when the ground warms up to about 4°C.",
                    HowToPlant = " Choose the Right Spinach Variety: \r\nSpinach varieties differ in their growth rates and flavors. \r\nBaby spinach: Grows quickly and is harvested young. \r\nSavoy spinach: Has crinkled leaves and is more cold-tolerant. \r\nFlat-leaf spinach: Has smooth leaves and is great for cooking. \r\nObtain spinach seeds from a reputable source or garden center. \r\n2. Light: \r\nPlant spinach where it will receive full sun to partial shade. It needs at least 3-4 hours of  direct sun daily. \r\n3. Prepare the Soil: \r\nSpinach prefers well-drained, fertile soil. Mix in compost or well-rotted manure to enrich  the soil. Loosen the soil to a depth of 15-20 cm. \r\n4. Planting: \r\nSow spinach seeds directly into the ground or containers. Plant seeds about 1 inch apart in  rows. Cover the seeds with a thin layer of soil (about 1/4 inch deep). Water gently to keep  the soil consistently moist. \r\n5. Growing Conditions: \r\nSpinach thrives in cool weather. Plant in early spring or late summer. Choose a sunny to  partially shaded spot. Keep the soil consistently moist but not waterlogged. \r\n6. Thinning: \r\nOnce the seedlings emerge, thin them out. Leave about 10-15 cm of space between each \r\nplant. Use thinned seedlings in salads or as microgreens. \r\n7. Successive Planting: \r\nTo enjoy spinach throughout the season, plant new seeds every 2-3 weeks. This ensures a  continuous harvest. \r\n",
                    Image = "spinach.jpeg",
                    DescriptionOfVeg = "Spinach is a leafy green vegetable prized for its nutritional benefits. It is packed with iron, calcium, and vitamins A and C. Spinach can be eaten raw in salads, blended into smoothies, or cooked in a variety of dishes such as soups, stews, and stir-fries",
                    CommonDiseases = "Downy Mildew Disease\r\nWhite Rust Disease\r\nAnthracnose Disease\r\nFusarium Wilt Disease\r\n",
                    VegetableColor = "#8CC342",
                    VegButtonColor = "#006838",
                };
                _dbConnection.Insert(vegetables);

            }

            //this table is for the selection of vegetables you can choose from

            if (_dbConnection.Table<VegetableType>().Count() == 0)
            {
                VegetableType vegetableType = new VegetableType()
                {
                    VegTypeID = 1,
                    VegTypeName = "Onions",
                    Description = "Onions are versatile vegetables known for their pungent flavor and strong aroma. They come in various colors, including white, yellow, and red, each adding a unique taste to dishes. Onions can be eaten raw, cooked, or pickled, and they are a staple ingredient in many cuisines worldwide.",
                    Image = "onions.jpg"
                };
                _dbConnection.Insert(vegetableType);

                vegetableType = new VegetableType()
                {
                    VegTypeID = 2,
                    VegTypeName = "Potatoes",
                    Description = "Potatoes are versatile tubers that are a staple food in many cultures. They come in various shapes, sizes, and colors, including russet, red, and purple. Potatoes can be baked, boiled, mashed, or fried, and they provide a good source of carbohydrates, potassium, and vitamin C.",
                    Image = "potatoes.jpg"
                };
                _dbConnection.Insert(vegetableType);

                vegetableType = new VegetableType()
                {
                    VegTypeID = 3,
                    VegTypeName = "Carrots",
                    Description = "Carrots are root vegetables known for their bright orange color and sweet, earthy flavor. They are an excellent source of beta-carotene, fiber, and various vitamins. Carrots can be eaten raw as a crunchy snack, cooked in a variety of dishes, or juiced for a healthy drink.",
                    Image = "carrot.jpg"
                };

                _dbConnection.Insert(vegetableType);

                vegetableType = new VegetableType()
                {
                    VegTypeID = 4,
                    VegTypeName = "Spinach",
                    Description = "Spinach is a leafy green vegetable prized for its nutritional benefits. It is packed with iron, calcium, and vitamins A and C. Spinach can be eaten raw in salads, blended into smoothies, or cooked in a variety of dishes such as soups, stews, and stir-fries.",
                    Image = "spinach.jpg"
                };
                _dbConnection.Insert(vegetableType);

                vegetableType = new VegetableType()
                {
                    VegTypeID = 5,
                    VegTypeName = "Tomatoes",
                    Description = "Tomatoes are juicy, red fruits often mistaken for vegetables. They are rich in vitamins and antioxidants, making them a healthy addition to any meal. Tomatoes can be enjoyed fresh in salads, cooked in sauces, or used as a base for soups and stews.",
                    Image = "tomatoes.jpg"
                };
                _dbConnection.Insert(vegetableType);


            }
            //On Friday I had the bright idea that once it has identified the disease it should be able to give you the control measures for that disease

            if (_dbConnection.Table<Disease>().Count() == 0)
            {
                Disease disease = new Disease()
                {
                    DiseaseID = 1,
                    DiseaseName = "Carrot Rust Fly",
                    DiseaseDescription = "",
                    DiseaseCauses = "The larvae of the carrot rust fly tunnel into the roots, causing damage and making the carrots unmarketable",
                    DiseaseControlMeasures = "To control this pest, you can use floating row covers to prevent adult flies from laying eggs on the plants or consider using appropriate insecticides.",
                    TagDescription = "Carrot Rust Fly Disease"

                };
                _dbConnection.Insert(disease);

                disease = new Disease()
                {
                    DiseaseID = 2,
                    DiseaseName = "Alternaria Leaf Blight",
                    DiseaseDescription = "",
                    DiseaseCauses = "This fungal disease affects the leaves and stems of carrot plants. It causes dark, sunken lesions on the leaves and can lead to defoliation if left untreated.",
                    DiseaseControlMeasures = "Crop rotation, proper sanitation, and the use of fungicides labeled for carrot diseases can help manage Alternaria leaf blight.",
                    TagDescription = "Alternaria Leaf Blight Disease"
                };
                _dbConnection.Insert(disease);

                disease = new Disease()
                {
                    DiseaseID = 3,
                    DiseaseName = "Root Knot Nematodes",
                    DiseaseDescription = "",
                    DiseaseCauses = "These microscopic worm-like organisms can cause galls or knots to form on the roots of carrot plants. Infected plants may show stunted growth and have reduced yields.",
                    DiseaseControlMeasures = "Crop rotation, soil solarization, and the use of resistant carrot varieties are effective management strategies for root knot nematodes.",
                    TagDescription = "Root Knot Nematodes Disease"
                };
                _dbConnection.Insert(disease);

                disease = new Disease()
                {
                    DiseaseID = 4,
                    DiseaseName = "Bacterial soft rot",
                    DiseaseDescription = "",
                    DiseaseCauses = "\"Bacterial soft rot is caused by various types of bacteria, with Erwinia carotovora being a common culprit. These bacteria can infect potatoes both in the ground and after harvest.\r\n   - The disease typically enters through wounds, such as lenticels, growth cracks, or any other injuries on the tubers¹³.\r\n   - Factors that favor bacterial soft rot include:\r\n     - Immature Tubers:Soft rot is more likely in immature tubers.\r\n     - Adverse Temperatures: Pulp temperatures above 21°C at harvest promote soft rot.\r\n     - Mechanical Damage: Bruising or cuts from digging forks provide entry points for bacteria.\r\n     - Free Water:Water on tuber surfaces encourages bacterial growth.\r\n\"",
                    DiseaseControlMeasures = "\"To prevent bacterial soft rot in potatoes, start with disease-free seed potatoes and rotate crops with non-host plants. Keep fields clean by removing infected plants and debris, and avoid planting in areas with a history of the disease. Proper irrigation, soil drainage, and careful handling during harvest and storage are crucial, while considering chemical treatments and biological controls as additional options to manage the disease effectively.\r\n\"",
                    TagDescription = "Bacterial Soft Rot Disease"
                };
                _dbConnection.Insert(disease);

                disease = new Disease()
                {
                    DiseaseID = 5,
                    DiseaseName = "Blackleg Disease",
                    DiseaseDescription = "",
                    DiseaseCauses = "Blackleg disease in potatoes is caused by pectolytic bacteria, specifically those in the genera Pectobacterium and Dickeya (formerly known as Erwinia)",
                    DiseaseControlMeasures = "\"To prevent blackleg disease in potatoes, start with healthy seed potatoes and rotate crops with different plants each year. Keep fields clean, avoid overwatering, and choose resistant potato varieties when possible to minimize the risk of disease.\r\n\"",
                    TagDescription = "Blackleg Disease"
                };
                _dbConnection.Insert(disease);

                disease = new Disease()
                {
                    DiseaseID = 6,
                    DiseaseName = "Late Blight(Potato)",
                    DiseaseDescription = "",
                    DiseaseCauses = "Late blight in potatoes is caused by the airborne spores of the Phytophthora infestans fungus. This disease manifests as irregular dark lesions on the stems and leaves of potato plants and spreads quickly. Late blight is a sporadic disease and is more likely to develop in cool, wet conditions.",
                    DiseaseControlMeasures = "\"To stop late blight in potatoes, pick resistant varieties and rotate crops yearly. Keep the potato area clean, removing any infected leaves promptly. Use fungicides during humid weather and water plants early in the day at the base to keep the foliage dry.\r\n\"",
                    TagDescription = "Late Blight Disease on Potato"
                };
                _dbConnection.Insert(disease);

                disease = new Disease()
                {
                    DiseaseID = 7,
                    DiseaseName = "Early blight(Potato)",
                    DiseaseDescription = "",
                    DiseaseCauses = "\"Alternaria solani is the primary culprit behind early blight.  Early blight doesn’t require excessive moisture it can even persist during drought periods.\r\nThe fungus tends to attack weakened plants, especially those with insect damage or reduced vitality due to other factors.\r\nShaded and older leaves are more susceptible to infection than young, vigorous ones.\"",
                    DiseaseControlMeasures = "\"To control early blight in potatoes, start by choosing potato varieties that resist the disease and rotate crops with different plants each season. Keep the potato patch clean by removing any infected leaves or debris, and water the plants at ground level to avoid splashing spores. If needed, apply natural or chemical fungicides according to instructions to further protect the plants from early blight.\r\n\"",
                    TagDescription = "Early Blight Disease"
                };
                _dbConnection.Insert(disease);

                disease = new Disease()
                {
                    DiseaseID = 8,
                    DiseaseName = "Powdery scab disease",
                    DiseaseDescription = "",
                    DiseaseCauses = "\"The disease is caused by Spongospora subterranea and can lead to significant yield losses.\r\n\r\n\"",
                    DiseaseControlMeasures = "\"To control powdery scab in potatoes, begin with disease-free seed potatoes, rotate crops, and maintain good field hygiene. Additionally, ensure proper soil drainage, monitor for early signs of the disease, and consider using resistant potato varieties if available.\r\n\"",
                    TagDescription = "Powdery Scab Disease"
                };
                _dbConnection.Insert(disease);

                disease = new Disease()
                {
                    DiseaseID = 9,
                    DiseaseName = "Anthracnose",
                    DiseaseDescription = "",
                    DiseaseCauses = "A fungal disease that affect spinach leaves and stems, causes dark, eater soaked lesions that turn tan or gray",
                    DiseaseControlMeasures = "Avoid overcrowding, ensure good drainage in your growing area.",
                    TagDescription = "Anthracnose Disease"

                };

                _dbConnection.Insert(disease);

                disease = new Disease()
                {
                    DiseaseID = 10,
                    DiseaseName = "Downy Mildew(Spinach)",
                    DiseaseDescription = "",
                    DiseaseCauses = "fungal diseases caused by Peronospora finosa can be identified by yellow or pale green spots on the upper surface of the leaves and a grayish-purple growth on the undersides",
                    DiseaseControlMeasures = "avoid overhead watering of crops, provide adequate spacing between plants for good air circulation.",
                    TagDescription = "Downy Mildew Disease"

                };
                _dbConnection.Insert(disease);

                disease = new Disease()
                {
                    DiseaseID = 11,
                    DiseaseName = "White Rust",
                    DiseaseDescription = "",
                    DiseaseCauses = "A fungal disease, causes raised, white pustules on the undersides of leaves and can lead to severe defoliation",
                    DiseaseControlMeasures = "practice crop rotation, remove infected plants to prevent the spread of white rust.",
                    TagDescription = "White Rust Disease"

                };
                _dbConnection.Insert(disease);

                disease = new Disease()
                {
                    DiseaseID = 12,
                    DiseaseName = "Fusarium Wilt",
                    DiseaseDescription = "",
                    DiseaseCauses = "Caused by a soil-borne fungal disease, noticeable by wilting, yellowing and stunting of plants",
                    DiseaseControlMeasures = "use disease-resistant spinach varieties, practice crop rotation.",
                    TagDescription = "Fusarium Wilt Disease"

                };
                _dbConnection.Insert(disease);

                disease = new Disease()
                {
                    DiseaseID = 13,
                    DiseaseName = "Botrytis Blight",
                    DiseaseDescription = "",
                    DiseaseCauses = "caused by Botrytis squamosa, this pathogen favours cool, moist conditions and the infection starts with elongated white spots",
                    DiseaseControlMeasures = "destroy onion or debris cull piles to reduces sources of inoculum, optimize plant row orientation and spacing to enhance air movement, reduce leaf wetness, implement a preventative fungicide spray program to manage the disease.",
                    TagDescription = "Botrytis Blight Disease"

                };
                _dbConnection.Insert(disease);

                disease = new Disease()
                {
                    DiseaseID = 14,
                    DiseaseName = "Botrytis neck rot",
                    DiseaseCauses = "disease is caused by prolonged exposure to wet conditions, spreads most rapidly during moderate temperatures with high humidity, rainfall or overhead irrigation. Storing uncured onions at temperatures and humidity that are too high can promote disease development and spread.",
                    DiseaseControlMeasures = "Adjust plant spacing and row orientation to obtain the best air movement through the plants, avoid injury to the onion neck and damage to the bulbs especially during harvest. Field applications of fungicides prior to harvest may reduce severity.",
                    TagDescription = "Botrytis Neck Rot Disease"
                };
                _dbConnection.Insert(disease);

                disease = new Disease()
                {
                    DiseaseID = 15,
                    DiseaseName = "Downy Mildew(Onion)",
                    DiseaseCauses = "Caused by the fungal disease Peronspora destructor that thrives in cool, humid conditions. Appears as pale green or yellow patches on the leaves which later turn brown",
                    DiseaseControlMeasures = "Ensure good airflow, proper spacing between crops and fungicide treatments.",
                    TagDescription = "Downy Mildew Disease"
                };
                _dbConnection.Insert(disease);

                disease = new Disease()
                {
                    DiseaseID = 16,
                    DiseaseName = "Purple blotch",
                    DiseaseCauses = "Caused by the fungus Alternarria porria, pathogen thrives in warm, moist conditions.",
                    DiseaseControlMeasures = "Applying a broad spectrum protective fungicides before infection can provide good protection, crop rotation is recommended after an outbreak, try to minimize leaf wetness by using  surface irrigation instead of sprinkler irrigation, ensure good field drainage and maintain correct plant spacing.",
                    TagDescription = "Purple Blotch Disease"
                };
                _dbConnection.Insert(disease);

                disease = new Disease()
                {
                    DiseaseID = 17,
                    DiseaseName = "Anthracnose",
                    DiseaseCauses = "Caused by several species of the fungus Colletotrichum. Ripe and overripe fruit are especially susceptible but the pathogen can infect green fruit with symptoms not developing until fruit begin to ripen. ",
                    DiseaseControlMeasures = "\"To stop anthracnose in tomatoes, keep the area clean by removing infected plants and\r\nrotating crops each year. Choose resistant tomato types and water plants carefully to keep\r\nthe leaves dry. Apply mulch, consider using fungicides if needed, and regularly check for\r\n\r\nsigns of the disease.\"",
                    TagDescription = "Anthracnose Disease"
                };
                _dbConnection.Insert(disease);

                disease = new Disease()
                {
                    DiseaseID = 18,
                    DiseaseName = "Blosom End Rot",
                    DiseaseCauses = "\nLow calcium levels in the soil.\r\nSoil that is over- or underwatered.\r\nWide fluctuations in soil moisture.\r\nInconsistent watering.\r\nLow soil pH.\r\nExcessive nitrogen.\n",
                    DiseaseControlMeasures = "\"To prevent blossom end rot in tomatoes, maintain consistent watering to avoid fluctuations\r\nin soil moisture. Ensure proper calcium levels in the soil through soil amendments or\r\nfertilizers containing calcium. Mulch around tomato plants to regulate soil temperature and\r\nmoisture, and avoid excessive nitrogen fertilization, which can interfere with calcium\r\n\r\nuptake.\"",
                    TagDescription = "Blossom End Rot Disease"

                };
                _dbConnection.Insert(disease);

                disease = new Disease()
                {
                    DiseaseID = 19,
                    DiseaseName = "Anthracnose",
                    DiseaseCauses = "Caused by several species of the fungus Colletotrichum. Ripe and overripe fruit are especially susceptible but the pathogen can infect green fruit with symptoms not developing until fruit begin to ripen. ",
                    DiseaseControlMeasures = "\"To stop anthracnose in tomatoes, keep the area clean by removing infected plants and\r\nrotating crops each year. Choose resistant tomato types and water plants carefully to keep\r\nthe leaves dry. Apply mulch, consider using fungicides if needed, and regularly check for\r\n\r\nsigns of the disease.\"",

                };
                _dbConnection.Insert(disease);

                disease = new Disease()
                {
                    DiseaseID = 20,
                    DiseaseName = "Blosom End Rot",
                    DiseaseCauses = "\nLow calcium levels in the soil.\r\nSoil that is over- or underwatered.\r\nWide fluctuations in soil moisture.\r\nInconsistent watering.\r\nLow soil pH.\r\nExcessive nitrogen.\n",
                    DiseaseControlMeasures = "\"To prevent blossom end rot in tomatoes, maintain consistent watering to avoid fluctuations\r\nin soil moisture. Ensure proper calcium levels in the soil through soil amendments or\r\nfertilizers containing calcium. Mulch around tomato plants to regulate soil temperature and\r\nmoisture, and avoid excessive nitrogen fertilization, which can interfere with calcium\r\n\r\nuptake.\"",
                    TagDescription = "Blosom End Rot Disease"
                };
                _dbConnection.Insert(disease);

                disease = new Disease()
                {
                    DiseaseID = 21,
                    DiseaseName = "Early blight ",
                    DiseaseCauses = "Early blight is caused by the fugus Alternaria linariae and occurs anytime during growing seaso, the pathogen is favoured by high humidity and temperatures above 24 degrees celsius.",
                    DiseaseControlMeasures = "\"To keep early blight away from tomatoes, use resistant varieties and rotate crops. Keep the\r\narea clean by removing infected leaves and debris, and space plants apart while mulching\r\nthe soil. Water at the base, prune for air flow, and consider using sprays if needed, while\r\n\r\nalways keeping an eye out for signs of the disease.\"",
                    TagDescription = "Early Blight Disease"
                };
                _dbConnection.Insert(disease);

                disease = new Disease()
                {
                    DiseaseID = 20,
                    DiseaseName = "Late blight",
                    DiseaseCauses = "Caused by the oomycete pathogen Phytophthora infestans, the pathogen prefers wet conditions with humid temperatures that span over 3-5 days",
                    DiseaseControlMeasures = "\"If you notice any signs of late blight (brown, gray, or purplish spots on leaves or stems),\r\npromptly remove and destroy the affected leaves. Late blight becomes more resistant to\r\n\r\ntreatment as it progresses, so early intervention is crucial.\"",
                    TagDescription = "Late Blight Disease"
                };
                _dbConnection.Insert(disease);

            }
            //In our UI we will have a list of diseases that are associated with the vegetable you have selected(Common diseases) so that information should comeback as a list from here
            if (_dbConnection.Table<VegetableDisease>().Count() == 0)
            {
                VegetableDisease vegDisease = new VegetableDisease()
                {
                    VegTypeID = 1,
                    DiseaseID = 13,
                };
                _dbConnection.Insert(vegDisease);



                vegDisease = new VegetableDisease()
                {
                    VegTypeID = 1,
                    DiseaseID = 14,
                };
                _dbConnection.Insert(vegDisease);


                vegDisease = new VegetableDisease()
                {
                    VegTypeID = 1,
                    DiseaseID = 15,
                };
                _dbConnection.Insert(vegDisease);



                vegDisease = new VegetableDisease()
                {
                    VegTypeID = 1,
                    DiseaseID = 16,
                };
                _dbConnection.Insert(vegDisease);


                vegDisease = new VegetableDisease()
                {
                    VegTypeID = 2,
                    DiseaseID = 4,
                };
                _dbConnection.Insert(vegDisease);

                vegDisease = new VegetableDisease()
                {
                    VegTypeID = 2,
                    DiseaseID = 5,
                };
                _dbConnection.Insert(vegDisease);

                vegDisease = new VegetableDisease()
                {
                    VegTypeID = 2,
                    DiseaseID = 6,
                };
                _dbConnection.Insert(vegDisease);

                vegDisease = new VegetableDisease()
                {
                    VegTypeID = 2,
                    DiseaseID = 7,
                };
                _dbConnection.Insert(vegDisease);

                vegDisease = new VegetableDisease()
                {
                    VegTypeID = 2,
                    DiseaseID = 8,
                };
                _dbConnection.Insert(vegDisease);

                vegDisease = new VegetableDisease()
                {
                    VegTypeID = 3,
                    DiseaseID = 1,
                };
                _dbConnection.Insert(vegDisease);

                vegDisease = new VegetableDisease()
                {
                    VegTypeID = 3,
                    DiseaseID = 2,
                };
                _dbConnection.Insert(vegDisease);

                vegDisease = new VegetableDisease()
                {
                    VegTypeID = 3,
                    DiseaseID = 3,
                };
                _dbConnection.Insert(vegDisease);

                vegDisease = new VegetableDisease()
                {
                    VegTypeID = 3,
                    DiseaseID = 4,
                };
                _dbConnection.Insert(vegDisease);

                vegDisease = new VegetableDisease()
                {
                    VegTypeID = 4,
                    DiseaseID = 10,
                };
                _dbConnection.Insert(vegDisease);

                vegDisease = new VegetableDisease()
                {
                    VegTypeID = 4,
                    DiseaseID = 11,
                };
                _dbConnection.Insert(vegDisease);

                vegDisease = new VegetableDisease()
                {
                    VegTypeID = 4,
                    DiseaseID = 12,
                };

                vegDisease = new VegetableDisease()
                {
                    VegTypeID = 5,
                    DiseaseID = 19,
                };
                _dbConnection.Insert(vegDisease);

                vegDisease = new VegetableDisease()
                {
                    VegTypeID = 5,
                    DiseaseID = 20,
                };
            }
        }


        // Methods to use Data(Still need to do this)

        public Disease GetDiseaseByTag(string tag)
        {
            var disease = _dbConnection.Table<Disease>().Where(vd => vd.TagDescription == tag).FirstOrDefault();
            return disease;
        }

        public List<Disease> GetDiseasesForVegetable(int vegTypeID)
        {
            // Get all VegetableDisease instances for the specified vegetable
            var vegDiseases = _dbConnection.Table<VegetableDisease>().Where(vd => vd.VegTypeID == vegTypeID).ToList();

            // Get all Disease instances for the diseases associated with the specified vegetable
            var diseases = new List<Disease>();
            foreach (var vegDisease in vegDiseases)
            {
                var disease = _dbConnection.Table<Disease>().FirstOrDefault(d => d.DiseaseID == vegDisease.DiseaseID);
                if (disease != null)
                {
                    diseases.Add(disease);
                }
            }

            return diseases;
        }
        public List<Vegetable> GetAllVegetables()
        {
            return _dbConnection.Table<Vegetable>().ToList();
        }


        // Crop Tracking Feature
        public CropTracking GetCropById(int cropid)
        {
            return _dbConnection.Table<CropTracking>().FirstOrDefault(u => u.CropID == cropid);
        }
        public List<CropTracking> GetAllCrops()
        {
            return _dbConnection.Table<CropTracking>().ToList();
        }
        public void CreateCrop(string name, string date, string wateramount, string growthamount, string notes)
        {
            CropTracking cropTracking = new CropTracking()
            {
                CropName = name,
                PlantDate = date,
                WaterAmount = wateramount,
                GrowthAmount = growthamount,
                Notes = notes,
            };
            _dbConnection.Insert(cropTracking);
        }
        public void DeleteCrop(int cropid)
        {
            var crop = _dbConnection.Table<CropTracking>().FirstOrDefault(c => c.CropID == cropid);
            if (crop != null)
            {
                _dbConnection.Delete(crop);
            }
        }
    }
}
