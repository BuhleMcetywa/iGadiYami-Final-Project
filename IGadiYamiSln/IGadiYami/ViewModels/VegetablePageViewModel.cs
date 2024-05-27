using CommunityToolkit.Mvvm.Input;
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
        }


        public VegetablePageViewModel(PlantDatabase database)
        {
            _database = database;
        }


        [RelayCommand]
        public void SetVegInfo(int index)
        {

        }


        public override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
