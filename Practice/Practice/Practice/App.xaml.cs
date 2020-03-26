using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practice
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new RelativeExercise();
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
