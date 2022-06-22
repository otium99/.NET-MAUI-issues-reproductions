using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OnesieMobile.Model;
using OnesieMobile.Services;
using OnesieMobile.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnesieMobile.ViewModel
{
    public partial class SettingsViewModel : BaseViewModel
    {
        [ObservableProperty]
        public DeviceInfoEntity deviceInfoEntity;

        [ObservableProperty]
        public SettingsEntity utcOffset;

        public SettingsViewModel()
        {

        }

        [ICommand]
        public async void SaveSettings()
        {
            await Shell.Current.GoToAsync("//MainPage", true);
        }

        [ICommand]
        public async void DeleteOnesieStorage()
        {

            await Shell.Current.GoToAsync("//MainPage", true, new Dictionary<string, object>
                {
                    {"ResetData", true }
                });
        }
    }
}
