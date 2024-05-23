using CommunityToolkit.Mvvm.Input;
using IGadiYami.Models;
using IGadiYami.Services;
using IGadiYami.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace IGadiYami.ViewModels
{
    [QueryProperty(nameof(Vegetable), "Vegetable")]
    public partial class VegetablePageViewModel : BaseViewModel
    {
        private PlantDatabase _database;


        private Vegetable _vegetable;
        public Vegetable Vegetable
        {
            get { return _vegetable; }
            set
            {
                _vegetable = value;
                _database.GetAllVegetables();
                OnPropertyChanged();
            }
        }
        // Properties for the buttons
        private string _vegetableinfo;
        public string VegetableInfo
        {
            get { return _vegetableinfo; }
            set { _vegetableinfo = value; OnPropertyChanged(); }
        }
        private string _vegheading;

        public string VegHeading
        {
            get { return _vegheading; }
            set { _vegheading = value; OnPropertyChanged();  }
        }

        private string _timeToPlant;

        public string TimeToPlant
        {
            get { return _timeToPlant; }
            set { _timeToPlant = value; OnPropertyChanged(); }
        }
        private string _soiltype;
        public string SoilType
        {
            get { return _soiltype; }
            set { _soiltype = value; OnPropertyChanged(); }
        }
        private string _howtoplant;
        public string HowToPlant
        {
            get { return _howtoplant; }
            set { _howtoplant = value; OnPropertyChanged(); }
        }
        private string _commondiseases;

        public string CommonDiseases
        {
            get { return _commondiseases; }
            set { _commondiseases = value; OnPropertyChanged(); }
        }



        public List<string> texts { get; set; }

        public VegetablePageViewModel(PlantDatabase database)
        {
            _database = database;
        }

        [RelayCommand]
        public void SetVegInfo(string index)
        {
            if (index == "howtoplant")
            {
                VegHeading = "How to Plant";
                VegetableInfo = Vegetable.HowToPlant;
            } else if (index == "choosingsoil")
            {
                VegHeading = "Choosing Right Soil";
                VegetableInfo = Vegetable.SoilType;
            }
            else if (index == "whentoplant")
            {
                VegHeading = "When to Plant";
                VegetableInfo = Vegetable.TimeToPlant;
            }
            else if (index == "commondisease")
            {
                VegHeading = "Common Diseases";
                VegetableInfo = Vegetable.WaterIntake;
            }
        }
        

        public override void OnAppearing()
        {
            base.OnAppearing();

            SetVegInfo("whentoplant");
        }
    }
}
