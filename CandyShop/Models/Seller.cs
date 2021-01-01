using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class Seller
    {
        public int SellerId { get; set; }
        public string SellerName { get; set; }
        public List<Candy> Candies { get; set;}

    }
}
