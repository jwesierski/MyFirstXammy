using System;
using MyFirstXammy.Services;
using MyFirstXammy.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstXammy
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

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
