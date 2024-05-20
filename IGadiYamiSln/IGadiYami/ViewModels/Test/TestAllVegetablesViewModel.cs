using CommunityToolkit.Mvvm.Input;
using IGadiYami.Models;
using IGadiYami.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGadiYami.ViewModels.Test
{
    public partial class TestAllVegetablesViewModel : BaseViewModel
    {
        private PlantDatabase _plantdatabase;
        private ObservableCollection<Vegetable> _vegetables;

        public ObservableCollection<Vegetable> Vegetables
        {
            get { return _vegetables; }
            set 
            { 
                _vegetables = value;
                OnPropertyChanged();
            }
        }


        public TestAllVegetablesViewModel(PlantDatabase plantDatabase)
        {
            _plantdatabase = plantDatabase;
        }

        [RelayCommand]
        public async Task VegetableSelected(Vegetable vegetables)
        {
           var navigationParameter = new Dictionary<string, object>
           {
                { "Vegetable", vegetables }
           };
            await Shell.Current.GoToAsync($"vegetable", navigationParameter);

        }
        public override void OnAppearing()
        {
            base.OnAppearing();

            Vegetables = new ObservableCollection<Vegetable>(_plantdatabase.GetAllVegetables());
        }
    }
}
