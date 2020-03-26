using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exercise1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Exercise1.HelloPage();
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
