using IGadiYami.Models;
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


namespace IGadiYami.Models
{
    public class VegetableDisease
    {
    
        
        [SQLiteNetExtensions.Attributes.ForeignKey(typeof(VegetableType))]
        public int VegTypeID{ get; set; }

        [SQLiteNetExtensions.Attributes.ForeignKey(typeof(Vegetable))]
        public int VegetableID { get; set; }

        [SQLiteNetExtensions.Attributes.ForeignKey(typeof(Disease))]
        public int DiseaseID { get; set; }


    }
}
