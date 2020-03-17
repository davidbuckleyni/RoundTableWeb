using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RoundTableWMS.Services;
using RoundTableWMS.Views;

namespace RoundTableWMS
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            Device.SetFlags(new string[] { "MediaElement_Experimental" });

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
