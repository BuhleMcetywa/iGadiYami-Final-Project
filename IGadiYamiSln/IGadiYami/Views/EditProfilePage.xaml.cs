namespace IgadiYamiDesign.Views;

public partial class EditProfilePage : ContentPage
{
	public EditProfilePage()
	{
		InitializeComponent();
	}
    private async void OnSaveClicked(object sender, EventArgs e)
    {
        // Handle Terms and Conditions click event
        await DisplayAlert("Save", "Saved updated information.", "OK");
    }
}