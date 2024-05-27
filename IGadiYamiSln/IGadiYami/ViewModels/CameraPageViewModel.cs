using Camera.MAUI;
using CommunityToolkit.Mvvm.Input;
using IGadiYami.Services;
using Xam.Plugins.OnDeviceCustomVision;
using IGadiYami.Models;

namespace IGadiYami.ViewModels
{
    public partial class CameraPageViewModel : BaseViewModel
    {
        private PlantDatabase _plantDatabase;

        private ImageSource _photo;
        public ImageSource Photo
        {
            get { return _photo; }
            set
            {
                _photo = value;
                OnPropertyChanged(nameof(Photo));
            }
        }
        private string _detectionresponse;
        public string DetectionResponse
        {
            get { return _detectionresponse; }
            set
            {
                _detectionresponse = value;

                OnPropertyChanged();
            }
        }
        private string _diseasecauses;
        public string DiseaseCauses
        {
            get { return _diseasecauses; }
            set { _diseasecauses = value; OnPropertyChanged(); }
        }

        CameraView _cameraView;

        public CameraPageViewModel(PlantDatabase plantDatabase)
        {
            _plantDatabase = plantDatabase;
        }

        public void SetCameraView(CameraView cameraView)
        {
            _cameraView = cameraView;
        }

        public void cameraView_CamerasLoaded(object sender, EventArgs e)
        {
            _cameraView.Camera = _cameraView.Cameras.First();
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                await _cameraView.StopCameraAsync();
                await _cameraView.StartCameraAsync();
            });
        }


        [RelayCommand]
        public async void DisplayResponse()
        {
            Stream stream = await _cameraView.TakePhotoAsync();

            MemoryStream ms = new MemoryStream();
            await stream.CopyToAsync(ms);
            ms.Position = 0;

            var classifications = await CrossImageClassifier.Current.ClassifyImage(ms);
            var highestProbabilityTag = classifications.OrderByDescending(c => c.Probability).First();
            DetectionResponse = highestProbabilityTag.Tag;

            var namePosition = highestProbabilityTag.Tag.IndexOf("(");
            var tagToSearch = highestProbabilityTag.Tag.Substring(0, namePosition - 1);

            var disease = _plantDatabase.GetDiseaseByTag(tagToSearch);

            if (disease != null)
            {
                // Get the causes and disease control measures
                DiseaseCauses = disease.DiseaseCauses;
            }
            else
            {
                DiseaseCauses = "";

            }
        }
    }
}