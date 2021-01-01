using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class SellerRepository : ISellerRepository
    {
        private readonly AppDbContext _appDbContext;

        public SellerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Seller> GetAllSellers()
        {
            return _appDbContext.Sellers.ToList();
        }

        public Seller GetSellerByName(string sellerName)
        {
            return _appDbContext.Sellers.SingleOrDefault(c => c.SellerName == sellerName);
        }
    }
}
