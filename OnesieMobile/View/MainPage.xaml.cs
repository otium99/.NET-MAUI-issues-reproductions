using OnesieMobile.Model;
using OnesieMobile.ViewModel;
using System.Diagnostics;

namespace OnesieMobile.View;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;

    }

	List<ActivityEntity> list = new() {
		new ActivityEntity() { ActivityID = "123", Deleted = true },
		new ActivityEntity() { ActivityID = "567", Deleted = false} };

	private void CrashButton_Pressed(object sender, EventArgs e)
	{
		List<ActivityEntity> listLocal = list.Where(l => !l.Deleted).ToList();
    }

	private void NoCrashButton_Pressed(object sender, EventArgs e)
	{
        List<ActivityEntity> listLocal = list.Where(l => l.Deleted == false).ToList();
    }
}

