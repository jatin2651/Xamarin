using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataAccess
{
    public partial class App : Application
    {
       
        public App()
        {
            InitializeComponent();

            MainPage = new Test();
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
