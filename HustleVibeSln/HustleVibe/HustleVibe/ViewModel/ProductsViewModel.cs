using HustleVibe.Model;
using HustleVibe.Services;
using System;
using HustleVibe.Helpers;
using HustleVibe.Model;
using HustleVibe.Services;
using HustleVibe.Views;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using static System.Net.Mime.MediaTypeNames;
using Application = Xamarin.Forms.Application;



namespace HustleVibe.ViewModel
{
    public class ProductsViewModel : BaseViewModel
    {
        private string _userName;
        public string UserName
        {
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
            get
            {
                return _userName;
            }
        }

        private int _UserCartItemsCount;
        public int UserCartItemsCount

        {
            set
            {
                _UserCartItemsCount = value;
                OnPropertyChanged();
            }

            get
            {
                return _UserCartItemsCount;
            }


        }

        public ObservableCollection<Category> Categories { get; set; }
        public ObservableCollection<Item> LatestItems { get; set; }

        public Command ViewCartCommand { get; set; }
        public Command LogoutCommand { get; set; }

        public ProductsViewModel(Item selectedItem)
        {
            var name = Preferences.Get("Username", string.Empty);
            if (string.IsNullOrEmpty(name))
                UserName = "Guest";
            else
                UserName = name;

            UserCartItemsCount = new CartItemService().GetUserCartCount();

            Categories = new ObservableCollection<Category>();
            LatestItems = new ObservableCollection<Item>();

            ViewCartCommand = new Command(async () => { await ViewCartAsync(); });
            LogoutCommand = new Command(async () => { await LogoutAsync(); });

            GetCategories();
            GetLatestItems();
        }


        private async Task ViewCartAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CartView());
        }

        private async Task LogoutAsync()

        {
            await Application.Current.MainPage.Navigation.PushAsync(new LogoutView());
        }
            private async void  GetCategories()
            {
              var data = await new CategoryDataService().GetCategoriesAsync();
              Categories.Clear();
              foreach(var item in data)
              {
                  Categories.Add(item);
              }

            }
            
            private async void GetLatestItems()
            {
               var data = await new ItemService().GetLatestItemsAsync();
               LatestItems.Clear();
               foreach(var item in data)
               {
                  LatestItems.Add(item);
               }

            }

        }

    }





