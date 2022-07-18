using System;
using System.Collections.Generic;
using HustleVibe.Helpers;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HustleVibe.Views
{

    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();

        }
       async void ButtonCategories_Clicked(Systems.Object sender, System.EventArgs e)
        {
            var acd = new AddCategoryData();
            await acd.AddCategoryAsync();
        }
        
       async void ButtonProducts_Clicked(Systems.Object sender, System.EventArgs e)
        {
            var afd = new AddItemData();
            await acd.AddItemAsync();
        }
        
    }
      
    }
