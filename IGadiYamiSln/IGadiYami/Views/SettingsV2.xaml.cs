namespace IgadiYamiDesign.Views;

public partial class SettingsV2 : ContentPage
{
	public SettingsV2()
	{
		InitializeComponent();
	}
    private async void OnEditProfileClicked(object sender, EventArgs e)
    {
        // Handle Edit profile click event
        await DisplayAlert("Edit Profile", "Edit profile clicked", "OK");
    }

    private async void OnPremiumTabClicked(object sender, EventArgs e)
    {
        // Handle Premium Tab click event
        await DisplayAlert("Premium Tab", "Premium tab clicked", "OK");
    }

    private async void OnFAQClicked(object sender, EventArgs e)
    {
        // Handle FAQ click event
        await DisplayAlert("FAQ", "FAQ clicked", "OK");
    }

    private async void OnHelpClicked(object sender, EventArgs e)
    {
        // Handle Help click event
        await DisplayAlert("Help", "Help clicked", "OK");
    }

    private async Task OnAboutUsClickedAsync(object sender, EventArgs e)
    {
        // Handle About Us click event that routes to the about us page
        await DisplayAlert("About Us", "About Us clicked", "OK");
    }

    private async void OnTermsAndConditionsClicked(object sender, EventArgs e)
    {
        // Handle Terms and Conditions click event
        await DisplayAlert("Terms and Conditions", "Terms and conditions clicked", "OK");
    }
}