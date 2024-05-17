using IGadiYami.Models.Vegetable_Type;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGadiYami.Models.Vegetable
{
    public class Vegetables
    {
        [PrimaryKey, AutoIncrement]
        public string VegetableID { get; set; }

        [ForeignKey(typeof(VegetableType))]
        public int VegTypeID { get; set; }
        public string Name { get; set; }
        public string SoilType { get; set; }
        public string WaterIntake { get; set; }
        public string SoilPrep { get; set; }
        public string TimeToPlant { get; set; }
        public string HowToPlant { get; set; }
    }
}
