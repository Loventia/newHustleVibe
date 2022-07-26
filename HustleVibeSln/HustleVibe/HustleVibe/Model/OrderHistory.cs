using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace HustleVibe.Model
{
   
        public class OrderHistory : List<OrderDetails>
        {
            public string OrderId { get; set; }
            public string Username { get; set; }
            public decimal TotalCost { get; set; }
            public string ReceiptId { get; set; }
        }
    
}
