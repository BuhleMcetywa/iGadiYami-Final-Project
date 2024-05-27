using SQLite;

namespace IGadiYami.Models
{
    public class Vegetable
    {
        [PrimaryKey, AutoIncrement]
        public int VegetableID { get; set; }
        public string DescriptionOfVeg { get; set; }
        public string Name { get; set; }
        public string SoilType { get; set; }
        public string WaterIntake { get; set; }
        public string SoilPrep { get; set; }
        public string TimeToPlant { get; set; }
        public string HowToPlant { get; set; }
        public string Image { get; set; }
    }
}
