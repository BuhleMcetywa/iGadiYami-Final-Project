using SQLite;

namespace IGadiYami.Models
{
    public class VegetableType
    {
        [PrimaryKey, AutoIncrement]
        public int VegTypeID { get; set; }
        public string Description { get; set; }

        public string VegTypeName { get; set; }

        public string Image { get; set; }
    }
}
