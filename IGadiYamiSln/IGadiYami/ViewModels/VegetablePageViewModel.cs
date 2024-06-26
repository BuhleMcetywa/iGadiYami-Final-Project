﻿using CommunityToolkit.Mvvm.Input;
using IGadiYami.Models;
using IGadiYami.Services;

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
            set { _vegheading = value; OnPropertyChanged(); }
        }
        private Color _vegetableColor;

        public Color VegetableColor
        {
            get { return _vegetableColor; }
            set { _vegetableColor = value; OnPropertyChanged(); }
        }
        private Color _vegbuttoncolor;

        public Color VegButtonColor
        {
            get { return _vegbuttoncolor; }
            set { _vegbuttoncolor = value; OnPropertyChanged(); }
        }



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
            }
            else if (index == "choosingsoil")
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
                VegetableInfo = Vegetable.CommonDiseases;
            }
        }


        public override void OnAppearing()
        {
            base.OnAppearing();
            SetVegInfo("whentoplant");
            VegetableColor = Color.FromRgba(Vegetable.VegetableColor);
            VegButtonColor = Color.FromRgba(Vegetable.VegButtonColor);

        }
    }
}
