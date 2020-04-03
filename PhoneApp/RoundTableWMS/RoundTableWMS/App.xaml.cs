using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RoundTableWMS.Services;
using RoundTableWMS.Views;
using Com.OneSignal;

namespace RoundTableWMS
{
    public partial class App : Application
    {
        public const string NotificationReceivedKey = "NotificationReceived";
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new string[] { "MediaElement_Experimental" });

            OneSignal.Current.StartInit("d2a05169-3da4-4c60-a224-3e6b7d2d1f8e")
                            .EndInit();
            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
