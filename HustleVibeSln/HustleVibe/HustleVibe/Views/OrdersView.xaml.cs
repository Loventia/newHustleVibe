using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HustleVibe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrdersView : ContentPage
    {
        public OrdersView(String id)
        {
            InitializeComponent();
            LabelName.Text = "Bienvenu" + Preferences.Get("Username", "Invite") + ",";
            LabelOrderID.Text = id;
        }

        private async void ImagButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void voirProduits_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ProductsView());
        }

    }
}