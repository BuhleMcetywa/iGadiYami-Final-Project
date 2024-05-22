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


        public List<string> texts { get; set; }
        public VegetablePageViewModel()
        {
            // Code for the buttons in the vegetable page
            texts = new List<string>
            {
                "text0",
                "text1",
                "text2",
                "text3",
            };
            SetVegInfoCommand = new RelayCommand<int>(SetVegInfo);
        }


        public VegetablePageViewModel(PlantDatabase database)
        {
            _database = database;
        }

        public ICommand SetVegInfoCommand { get; }
        //[RelayCommand]
        public void SetVegInfo(int index)
        {
            if (index == 0)
            {
                VegHeading = texts[0];
                App.Current.MainPage.DisplayAlert("alert", "command works", "ok");
            } else if (index == 1)
            {
                VegHeading = texts[1];
                App.Current.MainPage.DisplayAlert("alert", "command works", "ok");
            }
            else if (index == 2)
            {
                VegHeading = texts[2];
                App.Current.MainPage.DisplayAlert("alert", "command works", "ok");
            }
            else if (index == 3)
            {
                VegHeading = texts[3];
                App.Current.MainPage.DisplayAlert("alert", "command works", "ok");
            }
        }
        

        public override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
