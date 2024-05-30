using IGadiYami.Models;
using IGadiYami.Services;

namespace IGadiYami.ViewModels
{
    [QueryProperty(nameof(CropTracking), "TrackedCrop")]
    public class TrackedCropViewModel : BaseViewModel
    {
        private PlantDatabase _database;

        private CropTracking _cropTracking;
        public CropTracking CropTracking
        {
            get { return _cropTracking; }
            set
            {
                _cropTracking = value;
                _database.GetAllCrops();
                OnPropertyChanged();
            }
        }

        public TrackedCropViewModel(PlantDatabase plantDatabase)
        {
            _database = plantDatabase;
        }
    }
}
