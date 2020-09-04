using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileAppCasamento.Services;
using MobileAppCasamento.Views;

namespace MobileAppCasamento
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
