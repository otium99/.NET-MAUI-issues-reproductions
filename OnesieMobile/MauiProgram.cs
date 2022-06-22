using OnesieMobile.Model;
using OnesieMobile.Services;
using OnesieMobile.View;
using OnesieMobile.ViewModel;
using System.Net;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Text.Json;

namespace OnesieMobile;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
        //OnesieManager.WriteLogEntry("Maui App Started", "CreateMauiApp", false);

        AppDomain.CurrentDomain.FirstChanceException += CurrentDomain_FirstChanceException;

        var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<OnesieService>();

        builder.Services.AddTransient<MainPageViewModel>();
        builder.Services.AddTransient<MainPage>();

        return builder.Build();
	}

    private static void CurrentDomain_FirstChanceException(object sender, FirstChanceExceptionEventArgs e)
    {
        
        var trace = new System.Diagnostics.StackTrace();

        if (e != null && e.Exception != null)
            try
            {
                System.Diagnostics.Debug.WriteLine($"######### UNHANDLED EXCEPTION! DETAILS: #########" +
                    $"{e.Exception}");
            }
            catch (Exception ex)
            {
                ex.ToString();

            }

        if (sender != null)
            try
            {
                System.Diagnostics.Debug.WriteLine($"######### UNHANDLED EXCEPTION! SENDER: #########" +
                        $"{sender}");

            }
            catch (Exception ex)
            {
                ex.ToString();

            }

        if (trace != null)
            try
            {
                System.Diagnostics.Debug.WriteLine($"######### UNHANDLED EXCEPTION! TRACE: #########" +
                        $"{trace}");

            }
            catch (Exception ex)
            {
                ex.ToString();

            }


    }
}
