using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using HustleVibe.Model;

     
namespace HustleVibe.Helpers
{
    public  class AddCategoryData
    {
        public List<Category> Categories { get; set; }
        FirebaseClient client;

        public AddCategoryData() 
        {
            client = new FirebaseClient("https://hustlevibe-193fb-default-rtdb.firebaseio.com/");
            Categories= new List<Category>
        }
       
    }
}
