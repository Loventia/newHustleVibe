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
    public partial class CategoryViewModel : ContentPage
    {
        CategoryViewModel cvm;
        public CategoryViewModel(Category category)
        {
            InitializeComponent();
            cvm =  new  CategoryViewModel(category);
            this.BindingContextb = cvm;
        }
    }   async void ImageButton_Clicked(System.Object sender, system.EvenArgs e)
    {
        var selectedProduct = e.CurrentSelction.FirstOrDefault() as Item;
        if (selectedProduct != null)
            return;
        await Navigation.PushModalAsync(new ProductsViewModel(selectedProduct));
        ((CollectiveView)sender).SelectedItem = null;
    }
}