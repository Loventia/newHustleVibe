using System;


namespace HustleVibe.ViewModel
{
    public class ProductsViewModel : BaseViewModel
    {
        private string _userName;
        public string UserName
        {
            set
            {
                _UserName = value;
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

        public ProductsViewModel()
        {
            var name = Preference.Get("Username,string.Empty");
            if (string.IsNullOrEmpty(name))
                UserName = "Guest";
            else
                UserName = name;

            UserCartItemsCount = new CartItemService().GetUserCartCount();

            Categories = new ObservableCollection<Category>();
            LatestItems = new ObservableCollection<Item>();

            ViewCartCommand = new Command(async() = await ViewCartAsync());
            LogoutCommand = new Command(async() = await LogoutAsync());

            GetCategories();
            GetLatestItems();
        }

        private async Task ViewCartAsync()
        {
            await Application.Current.Mainpage.Navigation.PushModalAsync(new CartView());
        }

        private async Task LogoutAsync()

        {
            await Application.Current.Mainpage.Navigation.PushModalAsync(new LogoutView());
        }
            private async void  GetCategories()
            {
              var data = await new CategoryDataService().GetCategoriesAsync();
              Categories.Clear();
              foreach(var item in data)
              {
                  Categories.add(items);
              }

            }
            
            private async void GetLatestItems()
            {
               var data = await new ItemService().GetLatestItemsAsync();
               LatestItems.Clear();
               foreach(var item in data)
               {
                  LatestItems.Add(items);
               }

            }

        }

    }





