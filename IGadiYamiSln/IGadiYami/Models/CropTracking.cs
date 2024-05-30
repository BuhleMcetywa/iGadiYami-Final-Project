using SQLite;

namespace IGadiYami.Models
{
    public class CropTracking
    {
        [PrimaryKey, AutoIncrement]
        public int CropID { get; set; }
        public string CropName { get; set; }
        public string PlantDate { get; set; }
        public string WaterAmount { get; set; }
        public string GrowthAmount { get; set; }
        public string Notes { get; set; }
    }
}
