using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SholioLessonMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashScreenView : ContentPage
    {
        public SplashScreenView()
        {
            InitializeComponent();
            //Animate();
        }

        private async Task Animate()
        {
            imgLogo.Opacity = 0;
            await imgLogo.FadeTo(1, 4000);
            Application.Current.MainPage = new WordBaseView();
        }
    }
}