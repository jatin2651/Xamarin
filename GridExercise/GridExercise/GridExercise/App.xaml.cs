using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GridExercise
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GridExercise.GridView();
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
