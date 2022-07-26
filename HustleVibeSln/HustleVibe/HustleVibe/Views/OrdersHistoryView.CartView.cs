using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HustleVibe.Views
{
    public partial class OrdersHistoryView : ContentPage
    {
        public OrdersHistoryView.CartView

    [XamlCompilation(XamlCompilationOptions.Compile)]
    Internal; class CartView : ContentPage
    {
        public CartView()
        
        {
                InitializeComponent();
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page.Page());
        }
    }

  }