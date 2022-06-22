using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OnesieMobile.Model;
using OnesieMobile.Services;
using OnesieMobile.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnesieMobile.ViewModel
{
    public delegate void ScrollTo(int scrollPosition);

    public partial class MainPageViewModel : BaseViewModel
    {
        public ObservableCollection<ActivityEntity> ActivityEntities { get; } = new();

        [ObservableProperty]
        public DateTime currentDateTime;

        OnesieService onesieService;

        public MainPageViewModel(OnesieService onesieService)
        {
            Title = "Onesie";
            this.onesieService = onesieService;

            LoadActivityEntities();


            // The background process can be run with a Timer or with a recursive Thread.
            // Both lead to the same error.
            bool useTimer = false; 

            if (useTimer)
            {
                System.Timers.Timer t = new System.Timers.Timer(1000);
                t.Elapsed += T_Elapsed;
                t.Start();
            }
            else
            {
                Thread t = new Thread(BackgroundTask);
                t.Start();
            }
        }

        private void T_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (!IsBusy)
                ExecuteBackgroundProcess();
        }

        public void BackgroundTask()
        {
            if (!IsBusy)
                ExecuteBackgroundProcess();

            // Keep alive
            Thread.Sleep(1000);
            BackgroundTask();
        }

        private bool ExecuteBackgroundProcess()
        {
            // This line crashes the app. Comment this line out and the app runs fine
            CurrentDateTime = DateTime.Now;

            return true;
        }

        private void LoadActivityEntities()
        {
            ActivityEntities.Clear();
            for (int i = 0; i < 2; i++) // The error only occurs when there are more than 1 item in the list
            {
                ActivityEntities.Add(new ActivityEntity() { Title = Guid.NewGuid().ToString() });
            }
        }
    }
}
