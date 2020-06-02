using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SholioLessonMobileApp.Views;

namespace SholioLessonMobileApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SplashScreenView();
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
