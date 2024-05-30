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
            set { _crops = value; OnPropertyChanged(); }
        }


        public CropTrackingPageViewModel(PlantDatabase plantDatabase) 
        { 
            _plantdatabase = plantDatabase;
        }
        public override void OnAppearing()
        {
            base.OnAppearing();
            LoadData();
        }
        public void LoadData()
        {
            Crops = new ObservableCollection<CropTracking>(_plantdatabase.GetAllCrops());
        }

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
        }

        [RelayCommand]
        public void LoadCrop()
        {
            var returedData = _plantdatabase.GetCropById(3);
            CropName = returedData.CropName;
            PlantDate = returedData.PlantDate;
            WaterAmount = returedData.WaterAmount;
            GrowthAmount = returedData.GrowthAmount;
            Notes = returedData.Notes;
        }
    }
}
