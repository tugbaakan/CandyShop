using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public interface ISellerRepository
    {
        IEnumerable<Seller> GetAllSellers();
        Seller GetSellerByName(string sellerName);
    }
}
