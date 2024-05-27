namespace IGadiYami.Models
{
    public class VegetableDisease
    {


        [SQLiteNetExtensions.Attributes.ForeignKey(typeof(VegetableType))]
        public int VegTypeID { get; set; }

        [SQLiteNetExtensions.Attributes.ForeignKey(typeof(Disease))]
        public int DiseaseID { get; set; }


    }
}
