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
    public partial class OrderssHistoryView : ContentPage
    {
        public OrderssHistoryView()
        {
            InitializeComponent();
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page.Page());
        }
    }
}