namespace OnesieMobile;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using System;
using System.Diagnostics;
using Font = Microsoft.Maui.Font;

public partial class App : Application
{
	public App()
	{
        Debug.WriteLine("###########################################");
        Debug.WriteLine("Application launched");
        Debug.WriteLine("###########################################");

        InitializeComponent();

        Debug.WriteLine("###########################################");
        Debug.WriteLine("Application InitializeComponent finished");
        Debug.WriteLine("###########################################");


        //ShowSnackBar(1);

        MainPage = new AppShell();

        Debug.WriteLine("###########################################");
        Debug.WriteLine("MainPage assigned with AppShell");
        Debug.WriteLine("###########################################");


        //ShowSnackBar(2);
    }

    private async void ShowSnackBar(int snackNumber)
    {
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        var snackbarOptions = new SnackbarOptions
        {
            BackgroundColor = Colors.Red,
            TextColor = Colors.Green,
            ActionButtonTextColor = Colors.Yellow,
            CornerRadius = new CornerRadius(10),
            Font = Font.SystemFontOfSize(14),
            ActionButtonFont = Font.SystemFontOfSize(14),
            CharacterSpacing = 0.5
        };

        string text = "This is a Snackbar " + snackNumber;
        string actionButtonText = "Click Here to Dismiss";
        TimeSpan duration = TimeSpan.FromSeconds(60);

        var snackbar = Snackbar.Make(text, null, actionButtonText, duration, snackbarOptions);

        await snackbar.Show(cancellationTokenSource.Token);
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        Window window = base.CreateWindow(activationState);

        window.Created += (s, e) =>
        {
            // Custom logic
        };

        window.Activated += (s, e) =>
        {
            // Custom logic
        };

        window.Deactivated += (s, e) =>
        {
            // Custom logic
        };

        window.Stopped += (s, e) =>
        {
            // Custom logic
        };

        window.Resumed += (s, e) =>
        {
            // Custom logic
        };

        window.Destroying += (s, e) =>
        {
            // Custom logic
        };

        return window;
    }
}
