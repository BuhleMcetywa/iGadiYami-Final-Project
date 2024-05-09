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

        [RelayCommand]
        public async void TakePhoto()
        {
            if (MediaPicker.Default.IsCaptureSupported)
            {
                FileResult photo = await MediaPicker.Default.CapturePhotoAsync();

                if (photo != null)
                {
                    // save the file into local storage
                    string localFilePath = Path.Combine(FileSystem.CacheDirectory, photo.FileName);
                    using Stream sourceStream = await photo.OpenReadAsync();
                    using FileStream localFileStream = File.OpenWrite(localFilePath);
                    await sourceStream.CopyToAsync(localFileStream);
                }
            }
        }
    }
}
