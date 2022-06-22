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

}

