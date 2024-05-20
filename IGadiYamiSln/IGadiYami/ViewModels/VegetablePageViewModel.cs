using IGadiYami.Models;
using IGadiYami.Services;
using IGadiYami.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public VegetablePageViewModel(PlantDatabase database)
        {
            _database = database;
        }

        public override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
