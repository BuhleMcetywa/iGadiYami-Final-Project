using IGadiYami.Models;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGadiYami.Models
{
    public class Vegetable
    {
        [PrimaryKey, AutoIncrement]
        public int VegetableID { get; set; }

        [ForeignKey(typeof(VegetableType))]
        public VegetableType Description { get; set; }
        public string Name { get; set; }
        public string SoilType { get; set; }
        public string WaterIntake { get; set; }
        public string SoilPrep { get; set; }
        public string TimeToPlant { get; set; }
        public string HowToPlant { get; set; }

        public string Image { get; set; }
    }
}
