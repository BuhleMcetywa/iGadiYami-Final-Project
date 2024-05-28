using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.Input;
using IGadiYami.Services;
using IGadiYami.Views;

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


        public CropTrackingPageViewModel(PlantDatabase plantDatabase) 
        { 
            _plantdatabase = plantDatabase;
        }

        [RelayCommand]
        public async Task ShowPopUpAsync()
        {
            var popup = new CropTrackingPopUpPage(this);
            await Shell.Current.CurrentPage.ShowPopupAsync(popup); // Breakes Here
        }

        [RelayCommand]
        public void CreateCrop()
        {
            string nameEntry = CropName;
            string dateEntry = PlantDate;
            string waterEntry = WaterAmount;
            string growthEntry = GrowthAmount;
            string notesEntry = Notes;
            _plantdatabase.CreateCrop(nameEntry, dateEntry, waterEntry, growthEntry, notesEntry);
            CropName = "";
            PlantDate = "";
            WaterAmount = "";
            GrowthAmount = "";
            Notes = "";
        }

        [RelayCommand]
        public void LoadCrop()
        {
            var returedData = _plantdatabase.GetCropById(1);
            CropName = returedData.CropName;
            PlantDate = returedData.PlantDate;
            WaterAmount = returedData.WaterAmount;
            GrowthAmount = returedData.GrowthAmount;
            Notes = returedData.Notes;
        }
    }
}
