using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGadiYami.Models.Vegetable_Type
{
    public class VegetableType
    {
        [PrimaryKey, AutoIncrement]
        public int VegTypeID { get; set; }
        public string Description { get; set; }
        public string Carrot { get; set; }
        public string Tomato { get; set; }
        public string Onion { get; set; }
        public string Potato { get; set; }
        public string Spinach { get; set; }
    }
}
