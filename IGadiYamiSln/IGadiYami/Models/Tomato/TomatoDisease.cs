﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGadiYami.Models.Tomato
{
    public class TomatoDisease
    {
        [PrimaryKey, AutoIncrement]
        public int DiseaseID { get; set; }
        public string DiseaseName { get; set; }
        public string DiseaseDescription { get; set; }
        public string DiseaseCauses { get; set; }
        public string DiseaseControlMeasures { get; set; }
    }
}
