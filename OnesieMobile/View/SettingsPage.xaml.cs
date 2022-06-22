using OnesieMobile.ViewModel;

namespace OnesieMobile.View;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();

		BindingContext = new SettingsViewModel();
	}
}