﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace scarvajalS3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Navegacion

            MainPage = new NavigationPage(new Page1());
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
