using System;
using HustleVibe.Model;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace HustleVibe.Services
{
   
        public class CartItemService
        {
            public int GetUserCartCount()
            {
                var cn = DependencyService.Get<ILocalDb>().GetConnection();
                var count = cn.Table<CartItem>().Count();
                cn.Close();
                return count;
            }

            public void RemoveItemsFromCart()
            {
                var cn = DependencyService.Get<ILocalDb>().GetConnection();
                cn.DeleteAll<CartItem>();
                cn.Commit();
                cn.Close();
            }
        }

    
}
