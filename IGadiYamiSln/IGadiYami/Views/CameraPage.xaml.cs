using IGadiYami.ViewModels;

namespace IGadiYami.Views;

public partial class CameraPage : ContentPage
{
	CameraPageViewModel _viewModel;
	public CameraPage(CameraPageViewModel vm)
	{
        _viewModel = vm;
        InitializeComponent();
		BindingContext = _viewModel;

        _viewModel.SetCameraView(cameraView);
        cameraView.Loaded += _viewModel.cameraView_CamerasLoaded;

    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();
        await cameraView.StartCameraAsync();

    }
}