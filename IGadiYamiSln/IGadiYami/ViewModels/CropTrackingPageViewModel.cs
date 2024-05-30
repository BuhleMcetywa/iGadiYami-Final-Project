using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.Input;
using IGadiYami.Models;
using IGadiYami.Services;
using IGadiYami.Views;
using System.Collections.ObjectModel;

namespace IGadiYami.ViewModels
{
    public partial class CropTrackingPageViewModel : BaseViewModel
    {
        private PlantDatabase _plantdatabase;

        // Properties
        private string _cropname;
        public string CropName
        {
            get { return _cropname; }
            set { _cropname = value; OnPropertyChanged(); }
        }
        private string _plantdate;
        public string PlantDate
        {
            get { return _plantdate; }
            set { _plantdate = value; OnPropertyChanged(); }
        }
        private string _wateramount;
        public string WaterAmount
        {
            get { return _wateramount; }
            set { _wateramount = value; OnPropertyChanged(); }
        }
        private string _growthamount;
        public string GrowthAmount
        {
            get { return _growthamount; }
            set { _growthamount = value; OnPropertyChanged(); }
        }
        private string _notes;
        public string Notes
        {
            get { return _notes; }
            set { _notes = value; OnPropertyChanged(); }
        }

        private ObservableCollection<CropTracking> _crops;
        public ObservableCollection<CropTracking> Crops
        {
            get { return _crops; }
            set 
            { 
                _crops = value;
                //new ObservableCollection<CropTracking>(_plantdatabase.GetAllCrops());
                OnPropertyChanged(); 
            }
        }


        public CropTrackingPageViewModel(PlantDatabase plantDatabase) 
        { 
            _plantdatabase = plantDatabase;
            Crops = new ObservableCollection<CropTracking>(_plantdatabase.GetAllCrops());
        }
        /*public override void OnAppearing()
        {
            base.OnAppearing();
            LoadData();
        }
        public void LoadData()
        {
            
        }*/

        [RelayCommand]
        public async Task ShowPopUpAsync()
        {
            var popup = new CropTrackingPopUpPage(this);
            await Shell.Current.CurrentPage.ShowPopupAsync(popup);
        }

        [RelayCommand]
        public void CreateCrop()
        {
            _plantdatabase.CreateCrop(CropName, PlantDate, WaterAmount, GrowthAmount, Notes);
            CropName = "";
            PlantDate = "";
            WaterAmount = "";
            GrowthAmount = "";
            Notes = "";
            Crops = new ObservableCollection<CropTracking>(_plantdatabase.GetAllCrops());
        }

        [RelayCommand]
        public static async Task CropSelected(CropTracking cropTracking)
        {
            var navigationParameter = new Dictionary<string, object>
           {
                { "TrackedCrop", cropTracking }
           };
            await Shell.Current.GoToAsync($"trackedcrop", navigationParameter);

        }
    }
}
