using System;
using System.Collections.Generic;
using HustleVibe.Model;

namespace HustleVibe.Helpers
{
    public class AddItemData
    {
        private int ProductID;
        private int Catergory;
        private string ImageUrl;
        private string Name;
        private string Description;
        private string Rating;
        private string RatingDetail;
        private string HomeSelected;
        private int Price;

        public List<AddItemData>Items { get; set; }
            
        public AddItemData()
            {
            List<AddItemData> addItemDatas = new List<AddItemData>()
            {
              new AddItemData
              {
                    ProductID = 1,
                    Catergory = 1,
                    ImageUrl = "MainBurger",
                    Name = "Burger and Pizza Hub 1",
                    Description = "Burger - Pizza - Breakfast",
                    Rating = "4.8",
                    RatingDetail = "(121 raitings)",
                    HomeSelected = "CompleteHeart",
                    Price = 45

              },
                new AddItemData
                {
                    ProductID = 2,
                    Catergory = 1,
                    ImageUrl = "MainBurger",
                    Name = "Burger and Pizza Hub 2",
                    Description = "Burger - Pizza - Breakfast",
                    Rating = "4.8",
                    RatingDetail = "(121 raitings)",
                    HomeSelected = "EmptyHeart",
                    Price = 45
                },
                new AddItemData
                {
                    ProductID = 3,
                    Catergory = 1,
                    ImageUrl = "MainBurger",
                    Name = "Burger and Pizza Hub 4",
                    Description = "Burger - Pizza - Breaakfast",
                    Rating = "4.8",
                    RatingDetail = "(121 raiting)",
                    HomeSelected = "CompleteHeart",
                    Price = 45
                },
                new AddItemData
                {
                    ProductID = 4,
                    Catergory= 1,
                    ImageUrl = "MainBurger",
                    Name = "Burger and Pizza Hub",
                    Description = "Burger - Pizza - Breakfast ",
                    Rating = "4.8",
                    RatingDetail = "(121 raiting)",
                    HomeSelected = "EmtyHeart",
                    Price = 45

                },
                new AddItemData
                {
                    ProductID = 5,
                    Catergory = 2,
                    ImageUrl = "MainPizza",
                    Name = "Pizza",
                    Description = "Pizza - Breakefast",
                    Rating = "4.4",
                    RatingDetail = "(120 raitings)",
                    HomeSelected = "CompleteHeart",
                    Price = 45
                },
                new AddItemData
                {
                    ProductID = 6,
                    Catergory = 2,
                    ImageUrl = "Main Pizza",
                    Name = "Pizza Hub 2",
                    Description = "Pizza Hub 2 - Breakfast",
                    Rating = "4.8",
                    RatingDetail = "(156 raitings)",
                    HomeSelected = "EmtyHeart",
                    Price = 45,

                },
                new AddItemData
                {
                    ProductID = 7,
                    Catergory = 3,
                    ImageUrl = "MainDessert",
                    Name = "Ice Creams",
                    Description = "Icecream - Breakfast",
                    Rating = "4.4",
                    RatingDetail = "(120 raitings)",
                    HomeSelected = "CompleteHeart",
                    Price = 45
                },
                new AddItemData
                {
                    ProductID = 8,
                    Catergory = 3,
                    ImageUrl = "MainDessert",
                    Name = "Cakes",
                    Description = "Cool - Cakes - Breakfast",
                    Rating = "4.8",
                    RatingDetail = "(156 raitings)",
                    HomeSelected = "EmptyHeart",
                    Price = 45
                },

            };
           
        }
    }

   
}
