using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGadiYami.Models.Tomato
{
    public class Tomato
    {
        [PrimaryKey, AutoIncrement]
        public int TomatoID { get; set; }
        public string Name { get; set; }
        public string SoilType { get; set; }
        public string WaterIntake { get; set; }
        public string SoilPrep { get; set; }
        public string TimeToPlant { get; set; }

        [ForeignKey(typeof(TomatoDisease))]
        public int DiseaseID { get; set; }
    }
}
