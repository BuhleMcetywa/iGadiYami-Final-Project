using CommunityToolkit.Mvvm.Input;
using IGadiYami.Models;
using IGadiYami.Services;
using IGadiYami.ViewModels.PlantPageViewModels;
using IGadiYami.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGadiYami.ViewModels
{
    [QueryProperty(nameof(MainMenu), "StartGardening")]
    public partial class StartGardeningPageViewModel : BaseViewModel
    {
		private List<StartGardeningMenu> _startGardeningMenus;

		public List<StartGardeningMenu> StartGardeningMenus
		{
			get { return _startGardeningMenus; }
			set { _startGardeningMenus = value; OnPropertyChanged(); }
		}


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

        [RelayCommand]
        public static async Task VegetableSelected(Vegetable vegetables)
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


        public StartGardeningPageViewModel(PlantDatabase plantDatabase)
        {
            _plantdatabase = plantDatabase;
            // StartGardeningMenuOptionCollections();
        }


        void StartGardeningMenuOptionCollections()
        {
            StartGardeningMenus = new List<StartGardeningMenu>
    {
        new StartGardeningMenu
        {
            Name = "Onions",
            Description = "A cold-season crop, easy to grow and a staple in most gardens.",
            Image = "onions.jpg"
        },
        new StartGardeningMenu
        {
            Name = "Potatoes",
            Description = "A versatile root vegetable, rich in vitamins C, B6, and other nutrients.",
            Image = "potatoes.jpg"
        },
        new StartGardeningMenu
        {
            Name = "Spinach",
            Description = "A nutrient-rich leafy green vegetable, originated in Persia.",
            Image = "spinach.jpg"
        },
        new StartGardeningMenu
        {
            Name = "Tomatoes", // Changed from "Tomato" to "Tomatoes"
            Description = " A major source of antioxidant lycopene, linked to many health benefits.",
            Image = "tomatoes.jpg"
        },
        new StartGardeningMenu
        {
            Name = "Carrots",
            Description = "Rich in beta carotene, fiber, and antioxidants, known for numerous health benefits.",
            Image = "carrot.jpg"
        }
    };
        }

    }
}
