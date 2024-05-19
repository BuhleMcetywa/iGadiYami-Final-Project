using IGadiYami.Models.Diseases;
using IGadiYami.Models.Vegetable;
using IGadiYami.Models.Vegetable_Disease;
using IGadiYami.Models.Vegetable_Type;
using Microsoft.Maui.ApplicationModel;
using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IGadiYami.Services
{
    public class PlantDatabase : IPlantDatabase
    {
        private SQLiteConnection _dbConnection;
        public PlantDatabase()
        {
            _dbConnection = new SQLiteConnection(GetDatabasePath());
            _dbConnection.CreateTable<Disease>();
            _dbConnection.CreateTable<VegetableDisease>();
            _dbConnection.CreateTable<Vegetables>();
            _dbConnection.CreateTable<VegetableType>();
            SeedDatabase();
        }
        public string GetDatabasePath()
        {
            string fileName = "profiledatabase.db";
            string pathToDb = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return pathToDb + fileName;
        }
        public void SeedDatabase()
        {   //this table you use to access the specific vegetable you want to plant
           if(_dbConnection.Table<Vegetables>().Count() == 0)
            {
                Vegetables vegetables = new Vegetables()
                {
					Name = "Tomato",
					SoilType="",
                    WaterIntake = "",
                    SoilPrep = "",
                    TimeToPlant = "",
                    HowToPlant = "",
                    Image="",
					
				};
                _dbConnection.Insert(vegetables);

                vegetables = new Vegetables()
                {
					Name = "Onion",
					SoilType = "",
					WaterIntake = "",
					SoilPrep = "",
					TimeToPlant = "",
					HowToPlant = "",
					Image = "",

				};
                _dbConnection.Insert(vegetables);

                vegetables = new Vegetables()
                {
                    Name = "Potato",
                    SoilType = "",
                    WaterIntake = "",
                    SoilPrep = "",
                    TimeToPlant = "",
                    HowToPlant = "",
                    Image = "",
                };
                _dbConnection.Insert(vegetables); 

                vegetables = new Vegetables()
                {
					Name = "Carrot",
					SoilType = "",
					WaterIntake = "",
					SoilPrep = "",
					TimeToPlant = "",
					HowToPlant = "",
					Image = "",
				};

                _dbConnection.Insert(vegetables);

                vegetables = new Vegetables()
                {
                    Name = "Spinach",
                    SoilType = "",
                    WaterIntake = "",
                    SoilPrep = "",
                    TimeToPlant = "",
                    HowToPlant = "",
                    Image = "",
                };
                _dbConnection.Insert(vegetables);

           }

		   //this table is for the selction of vegetables you can choose from

            if (_dbConnection.Table<VegetableType>().Count() == 0)
            {
                VegetableType vegetableType = new VegetableType()
                {
                    VegTypeID = 1,
					VegTypeName = "Onions",
					Description = "",
					Image = ""
				};
                _dbConnection.Insert(vegetableType);

                vegetableType = new VegetableType()
                {
                    VegTypeID = 2,
                    VegTypeName = "Potatoes",
                    Description = "",
                    Image = ""
                };
                _dbConnection.Insert(vegetableType);

                vegetableType = new VegetableType()
                {
					VegTypeID = 3,
					VegTypeName = "Carrots",
					Description = "",
					Image = ""
				}; 
                
                _dbConnection.Insert(vegetableType);

				vegetableType = new VegetableType()
                {
					VegTypeID = 4,
					VegTypeName = "Spinach",
					Description = "",
					Image = ""
				};
				_dbConnection.Insert(vegetableType);

				vegetableType = new VegetableType()
                {
					VegTypeID = 5,
					VegTypeName = "Tomatoes",
					Description = "",
					Image = ""
				};
				_dbConnection.Insert(vegetableType);

                
            }
			//On Friday I had the bright idea that once it has identified the disease it should be able to give you the control measures for that disease

            if (_dbConnection.Table<Disease>().Count()== 0)
            {
				Disease disease = new Disease()
                {
					DiseaseID = 1,
					DiseaseName = "Bacterial Spot",
					DiseaseDescription = "",
					DiseaseCauses = "",
					DiseaseControlMeasures = "",
					
				};
				_dbConnection.Insert(disease);

				disease = new Disease()
                {
					DiseaseID = 2,
					DiseaseName = "Bacterial Spot",
					DiseaseDescription = "",
					DiseaseCauses = "",
					DiseaseControlMeasures = "",
					
				};
				_dbConnection.Insert(disease);

				disease = new Disease()
                {
					DiseaseID = 3,
					DiseaseName = "Bacterial Spot",
					DiseaseDescription = "",
					DiseaseCauses = "",
					DiseaseControlMeasures = "",
					
				};
				_dbConnection.Insert(disease);

				disease = new Disease()
                {
					DiseaseID = 4,
					DiseaseName = "Bacterial Spot",
					DiseaseDescription = "",
					DiseaseCauses = "",
					DiseaseControlMeasures = "",

				};
				_dbConnection.Insert(disease);

				disease = new Disease()
                {
					DiseaseID = 5,
					DiseaseName = "Bacterial Spot",
					DiseaseDescription = "",
					DiseaseCauses = "",
					DiseaseControlMeasures = "",

				};
				_dbConnection.Insert(disease);

				disease = new Disease()
                {
					DiseaseID = 6,
					DiseaseName = "Bacterial Spot",
					DiseaseDescription = "",
					DiseaseCauses = "",
					DiseaseControlMeasures = "",

				};
				_dbConnection.Insert(disease);

				disease = new Disease()
                {
					DiseaseID = 7,
					DiseaseName = "Bacterial Spot",
					DiseaseDescription = "",
					DiseaseCauses = "",
					DiseaseControlMeasures = "",

				};
				_dbConnection.Insert(disease);

				disease = new Disease()
                {
					DiseaseID = 8,
					DiseaseName = "Bacterial Spot",
					DiseaseDescription = "",
					DiseaseCauses = "",
					DiseaseControlMeasures = "",

				};
				_dbConnection.Insert(disease);

				disease = new Disease()
				{
					DiseaseID = 9,
					DiseaseName = "Bacterial Spot",
					DiseaseDescription = "",
					DiseaseCauses = "",
					DiseaseControlMeasures = "",
				};

					_dbConnection.Insert(disease);

				disease = new Disease()
				{
					DiseaseID = 10,
					DiseaseName = "Bacterial Spot",
					DiseaseDescription = "",
					DiseaseCauses = "",
					DiseaseControlMeasures = "",

				};
				_dbConnection.Insert(disease);

				disease = new Disease()
				{
					DiseaseID = 11,
					DiseaseName = "Bacterial Spot",
					DiseaseDescription = "",
					DiseaseCauses = "",
					DiseaseControlMeasures = "",
				
				};
				_dbConnection.Insert(disease);

				disease = new Disease()
				{
					DiseaseID = 12,
					DiseaseName = "Bacterial Spot",
					DiseaseDescription = "",
					DiseaseCauses = "",
					DiseaseControlMeasures = "",

				};
				_dbConnection.Insert(disease);

				disease = new Disease()
				{
					DiseaseID = 13,
					DiseaseName = "Bacterial Spot",
					DiseaseDescription = "",
					DiseaseCauses = "",
					DiseaseControlMeasures = "",

				};
				_dbConnection.Insert(disease);

			}
			//In our UI we will have a list of diseases that are associated with the vegetable you have selected(Common diseases) so that information should comeback as a list from here
			if (_dbConnection.Table<VegetableDisease>().Count() == 0)
			{
				var diseasesforCarrots = new List<int> { 1, 2, 3, 4 }; // List of DiseaseIDs

				foreach (var diseaseId in diseasesforCarrots)
				{
					VegetableDisease vegDisease = new VegetableDisease()
					{
						VegTypeID = 1, // VegTypeID
						DiseaseID = diseaseId  // DiseaseID from the list
					};
					_dbConnection.Insert(vegDisease);
				}

				var diseasesforPotatoes = new List<int> { 5, 6, 7, 8 }; // List of DiseaseIDs

				foreach (var diseaseId in diseasesforPotatoes)
				{
					VegetableDisease vegDisease = new VegetableDisease()
					{
						VegTypeID = 2, // VegTypeID
						DiseaseID = diseaseId  // DiseaseID from the list
					};
					_dbConnection.Insert(vegDisease);
				}

				var diseasesforOnions = new List<int> { 9, 10, 11, 12 }; // List of DiseaseIDs

				foreach (var diseaseId in diseasesforOnions)
				{
					VegetableDisease vegDisease = new VegetableDisease()
					{
						VegTypeID = 3, // VegTypeID
						DiseaseID = diseaseId  // DiseaseID from the list
					};
					_dbConnection.Insert(vegDisease);
				}

				var diseasesforSpinach = new List<int> { 13 }; // List of DiseaseIDs
				foreach (var diseaseId in diseasesforSpinach)
				{
					VegetableDisease vegDisease = new VegetableDisease()
					{
						VegTypeID = 4, // VegTypeID
						DiseaseID = diseaseId  // DiseaseID from the list
					};
					_dbConnection.Insert(vegDisease);
				}	

				var diseasesforTomatoes = new List<int> { 1, 2, 3, 4 }; // List of DiseaseIDs
				foreach (var diseaseId in diseasesforTomatoes)
				{
					VegetableDisease vegDisease = new VegetableDisease()
					{
						VegTypeID = 5, // VegTypeID
						DiseaseID = diseaseId  // DiseaseID from the list
					};
					_dbConnection.Insert(vegDisease);
				}

				
			}

		}


		// Methods to use Data(Still need to do this)

	}
}
