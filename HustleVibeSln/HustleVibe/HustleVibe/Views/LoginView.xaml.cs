﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HustleVibe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
            //MainPage = new MainPage();
            MainPage = new LoginView();
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