using IGadiYami.Models.Diseases;
using IGadiYami.Models.Vegetable;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLiteNetExtensions.Attributes;
using System;
using IGadiYami.Models.Vegetable_Type;

namespace IGadiYami.Models.Vegetable_Disease
{
    public class VegetableDisease
    {
    
        
        [SQLiteNetExtensions.Attributes.ForeignKey(typeof(VegetableType))]
        public int VegTypeID{ get; set; }

        [SQLiteNetExtensions.Attributes.ForeignKey(typeof(Disease))]
        public int DiseaseID { get; set; }


    }
}
