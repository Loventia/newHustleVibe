using System;
using System.Collections.ObjectModel;
using HustleVibe.Model;

namespace HustleVibe.ViewModel
{
    public class CategoryViewModel : BaseViewModel
    {
        private Category_SelectedCategory;
        public Category SelectedCategory
        {
            set
            {
                _SelectedCategory = value;
                OnPropertyChanged();
            }

            get
            {
                return_SelectedCategory;
            }
        }

        public ObservableCollection<Item> ItemByCategory { get; set; }

        private int _TotalItems;
        public int TotalItems
        {
            set
            {
                _TotalItems = value;
                OnPropertyChanged();
            }
            get
            {
                return _TotalItems;
            }
        }

        public CategoryViewModel(Category category )
        {
            SelectedCategory = category;
            ItemsByCategory = new ObservableCollection<Item>();
            GetItems(category.CategoryID);
        }

        private async void GetItems(int categoryID)
        {
            var data = await new ItemService().GetItemsByCategoryAsync(categoryID);
            ItemsByCategory.Clear();
            foreach (var item in data)
            {
                ItemsByCategory.Add(items);
            }

            TotalItems = ItemsByCategory.Count;
        }

    }
}
