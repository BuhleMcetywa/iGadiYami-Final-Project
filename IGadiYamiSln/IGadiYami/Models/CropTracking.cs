using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGadiYami.Models
{
    public class CropTracking
    {
        public int CropID { get; set; }
        public string CropName { get; set; }
        public string PlantDate { get; set; }
        public string WaterAmount { get; set; }
        public string GrowthAmount { get; set; }
        public string Notes { get; set; }
    }
}
