using IGadiYami.ViewModels;

namespace IGadiYami.Views;

public partial class TrackedCrop : ContentPage
{
    public TrackedCrop(TrackedCropViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}