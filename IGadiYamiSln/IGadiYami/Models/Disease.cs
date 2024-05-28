using SQLite;

namespace IGadiYami.Models
{
    public class Disease
    {
        [PrimaryKey, AutoIncrement]
        public int DiseaseID { get; set; }
        public string DiseaseName { get; set; }
        public string DiseaseDescription { get; set; }
        public string DiseaseCauses { get; set; }
        public string DiseaseControlMeasures { get; set; }
        public string TagDescription { get; set; }

    }
}
