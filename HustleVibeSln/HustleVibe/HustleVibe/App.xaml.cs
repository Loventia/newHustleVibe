﻿using HustleVibe.Views;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HustleVibe
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new string[]
          {
                 "AppTheme_Experimental",
                "MediaElement_Experimental"
          });
            // MainPage = new MainPage();
            MainPage = new LoginView();


            string uname = Preferences.Get("Username", string.Empty);
            if (string.IsNullOrEmpty(uname))
            {
                MainPage = new LoginView();
            }
            else
            {

                MainPage = new NavigationPage(new ProductsView());

            }
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
