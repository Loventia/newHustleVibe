using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HustleVibe.Views
{
<<<<<<<< HEAD:HustleVibeSln/HustleVibe/HustleVibe/Views/OrdersHistoryView.xaml.cs
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderssHistoryView : ContentPage
    {
        public OrderssHistoryView()
========
    [XamlCompilation (XamlCompilationOptions.Compile)]
    public partial class CartView : ContentPage
    {
        public CartView()
>>>>>>>> 660c805adbb9147f4c144f644eb4098763335174:HustleVibeSln/HustleVibe/HustleVibe/Views/CartView.xaml.cs
        {
            InitializeComponent();
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page.Page());
        }
    }
}