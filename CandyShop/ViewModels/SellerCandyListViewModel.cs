
using CandyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.ViewModels
{
    public class SellerCandyListViewModel
    {
        public IEnumerable<Candy> Candies { get; set; }
        public string CurrentSeller { get; set; }

    }
}
