﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Day2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Day2.list();
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
