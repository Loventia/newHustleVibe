using HustleVibe.Model;
using HustleVibe.ViewModel;
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
            this.BindingContext = cvm;
        }

       async void ImageButton_Clicked(System.Object sender, SelectionChangedEventArgs e)
    {
        var selectedProduct = e.CurrentSelection.FirstOrDefault() as Item;
        if (selectedProduct != null)
            return;
        await Navigation.PushModalAsync(new ProductsViewModel(selectedProduct));
        ((CollectionView)sender).SelectedItem = null;
    }
}