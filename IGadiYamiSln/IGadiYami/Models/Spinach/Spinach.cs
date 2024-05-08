using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGadiYami.Models.Spinach
{
    public class Spinach
    {
        [PrimaryKey, AutoIncrement]
        public int SpinachID { get; set; }
        public string Name { get; set; }
        public string SoilType { get; set; }
        public string WaterIntake { get; set; }
        public string SoilPrep { get; set; }
        public string TimeToPlant { get; set; }

        [ForeignKey(typeof(SpinachDisease))]
        public int DiseaseID { get; set; }
    }
}
