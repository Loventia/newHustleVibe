using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database.Query;
using System.Linq;
using HustleVibe.Model;
using Firebase.Database;

namespace HustleVibe.Helpers
{
    public  class AddCategoryData
    {
        public List<Category> Categories { get; set; }
        FirebaseClient client;

        public AddCategoryData() 
        {
            client = new FirebaseClient("https://hustlevibe-193fb-default-rtdb.firebaseio.com/");
            Categories = new List<Category>()
            {

                new Category()
                {
                    CategoryID=1,
                     CategoryName="Agriculture",
                     CategoryPoster="Mainburger",
                     ImageUrl= ""


                },

                new Category()
                {
                    CategoryID=2,
                     CategoryName="Home services",
                     CategoryPoster="Mainburger",
                     ImageUrl= ""

                },
                new Category()
                {
                    CategoryID=3,
                     CategoryName="Auto services",
                     CategoryPoster="Mainburger",
                     ImageUrl= ""
                },
                new Category()
                {
                    CategoryID=4,
                     CategoryName="Food",
                     CategoryPoster="Mainburger",
                     ImageUrl= ""
                },
                new Category()
                {
                    CategoryID=5,
                     CategoryName="Beauty",
                     CategoryPoster="Mainburger",
                     ImageUrl= ""
                }

            };
        }

        private async Task AddCategoriesAsync()
        {
            var categories = (await client.Child("Categories"))
                .OnceAsync<Category>()
                .Select(c => new Category

                {
                    CategoryID = c.Object.CategoryID,
                    CategoryName = c.Object.CategoryName,
                    CategoryPoster = c.Object.CategoryPoster,
                    ImageUrl = c.Object.ImageUrl
                }).ToList();
            return Categories;
        }

    }
}

