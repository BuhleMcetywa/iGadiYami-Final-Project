using Camera.MAUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IGadiYami.Views;
using System.Windows.Input;

namespace IGadiYami.ViewModels
{
    public class CameraPageViewModel : BaseViewModel
    {
        public CameraPageViewModel()
        {

        }

        private async void CameraView_CamerasLoaded(object sender, EventArgs e)
        {
            //cameraView.Camera = cameraView.Cameras.First();
            //MainThread.BeginInvokeOnMainThread(async () => {
              //  await cameraView.StartCameraAsync();
            //});
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            // myImage.Source = cameraView.GetSnapShot(Camera.MAUI.ImageFormat.PNG);
        }
    }
}
