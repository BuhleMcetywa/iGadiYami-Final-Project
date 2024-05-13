using Camera.MAUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IGadiYami.Views;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace IGadiYami.ViewModels
{
    public partial class CameraPageViewModel : BaseViewModel
    {
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

        CameraView _cameraView;

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
        public void TakePhoto()
        {
            Photo = _cameraView.GetSnapShot(Camera.MAUI.ImageFormat.PNG);
        }
    }
}
