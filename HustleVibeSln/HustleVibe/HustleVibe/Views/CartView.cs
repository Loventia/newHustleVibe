﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Task;
using Xamarin .Essentials;
using Xamarin.Forms;
using Xamarin.Form.Xaml;

namespace HustleVibe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartView : ContentPage
    {
        public CartView()
        {
            InitializeComponent();
            LabelName.Text = "Welcome" + Preferences.Get("Username", "Invité") + ",";
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }

}
 